using UnityEngine;
using System.Collections; 
using UnityEngine.SceneManagement; 
using ML; 

public class GlobalRoomManager : MonoBehaviour
{
    [Header("Game Settings")]
    [Tooltip("1 = Full Hint, 2 = No Drop Hint, 3 = Mastery (No Hint)")]
    [Range(1, 3)] public int currentLevelStage = 1; 

    [Header("Scene Management")]
    public string level2SceneName = "VR Basic_Level 2";
    public string level3SceneName = "VR Basic_Level 3";

    [Header("Managers")]
    public TrashManager trashManager;
    public BedTaskManager bedManager;
    public TowelTaskManager towelManager;

    [Header("Hint Scripts")]
    public TrashHintController trashHintScript;
    public BedHintController bedHintScript;
    public TowelHintController towelHintScript;

    [Header("Hint Visuals")]
    public GameObject trashDiamondObj;
    public GameObject bedDiamondObj;
    public GameObject towelDiamondObj;

    private void Start()
    {
        if (trashHintScript) trashHintScript.SetLevel(currentLevelStage);
        if (bedHintScript) bedHintScript.SetLevel(currentLevelStage);
        if (towelHintScript) towelHintScript.SetLevel(currentLevelStage);

        StartCoroutine(InitSequence());
    }

    IEnumerator InitSequence()
    {
        Debug.Log($"GlobalManager: Starting Level Mode {currentLevelStage}...");
        yield return new WaitForSeconds(0.1f);
        DisableAllTasks();
        yield return new WaitForSeconds(1.0f);
        StartTrashTask();
    }

    void DisableAllTasks()
    {
        if (trashManager) trashManager.ToggleInteraction(false);
        if (bedManager) bedManager.ToggleInteraction(false);
        if (towelManager) towelManager.ToggleInteraction(false);

        if (trashHintScript) trashHintScript.enabled = false;
        if (bedHintScript) bedHintScript.enabled = false;
        if (towelHintScript) towelHintScript.enabled = false;

        if (trashDiamondObj) trashDiamondObj.SetActive(false);
        if (bedDiamondObj) bedDiamondObj.SetActive(false);
        if (towelDiamondObj) towelDiamondObj.SetActive(false);
    }

    // --- PHASE 1: TRASH ---
    void StartTrashTask()
    {
        Debug.Log(">>> PHASE 1 STARTED: TRASH <<<");

        if (VRTrainingRecorder.Instance != null)
        {
            VRTrainingRecorder.Instance.current_level = currentLevelStage;
            VRTrainingRecorder.Instance.StartRecording();
        }

        if (trashManager) trashManager.ToggleInteraction(true);
        if (trashHintScript) trashHintScript.enabled = true;
        if (trashDiamondObj) trashDiamondObj.SetActive(true);
    }

    public void OnTrashFinished()
    {
        Debug.Log(">>> PHASE 1 COMPLETED <<<");

        if (trashManager) trashManager.ToggleInteraction(false);
        if (trashHintScript) trashHintScript.enabled = false;
        if (trashDiamondObj) trashDiamondObj.SetActive(false);

        StartBedTask();
    }

    // --- PHASE 2: BED ---
    void StartBedTask()
    {
        Debug.Log(">>> PHASE 2 STARTED: BED <<<");

        if (bedManager) bedManager.ToggleInteraction(true);
        if (bedHintScript) bedHintScript.enabled = true;
        if (bedDiamondObj) bedDiamondObj.SetActive(true);
    }

    public void OnBedFinished()
    {
        Debug.Log(">>> PHASE 2 COMPLETED <<<");

        if (bedManager) bedManager.ToggleInteraction(false);
        if (bedHintScript) bedHintScript.enabled = false;
        if (bedDiamondObj) bedDiamondObj.SetActive(false);

        StartTowelTask();
    }

    // --- PHASE 3: TOWEL ---
    void StartTowelTask()
    {
        Debug.Log(">>> PHASE 3 STARTED: TOWEL <<<");

        if (towelManager) towelManager.ToggleInteraction(true);
        if (towelHintScript) towelHintScript.enabled = true;
        if (towelDiamondObj) towelDiamondObj.SetActive(true);
    }

    public void OnTowelFinished()
    {
        Debug.Log(">>> ALL TASKS COMPLETED <<<");

        // 1. Matikan interaksi
        if (towelManager) towelManager.ToggleInteraction(false);
        if (towelHintScript) towelHintScript.enabled = false;
        if (towelDiamondObj) towelDiamondObj.SetActive(false);

        // 2. Stop recording
        if (VRTrainingRecorder.Instance != null)
        {
            VRTrainingRecorder.Instance.StopAndSave();
        }

        // 3. AI prediction & Rule-Based Logic
        double[] rawFeatures = null;
        double prob_pass = 0.0;

        if (VRTrainingRecorder.Instance != null)
        {
            // Ambil 6 fitur mentah
            rawFeatures = VRTrainingRecorder.Instance.GetModelFeatureVector();

            // Standardisasi fitur untuk masuk ke model
            double[] scaledFeatures = RandomForestModel.Standardize(rawFeatures);

            double[] prediction = RandomForestModel.Score(scaledFeatures);

            if (prediction != null && prediction.Length >= 2)
            {
                prob_pass = prediction[1]; // Probabilitas Lulus
                Debug.Log($"AI Raw Score: Fail={prediction[0]:F4}, Pass={prediction[1]:F4}");
            }
        }
        else
        {
            Debug.LogError("VRTrainingRecorder.Instance tidak ditemukan.");
            return; // Hentikan eksekusi jika tidak ada data
        }

        // 4. Kalkulasi Risiko dan Keputusan Leveling
        var riskResult = CalculateRisk(rawFeatures);
        var decisionResult = LevelingDecision(prob_pass, riskResult.hardFail, riskResult.riskReason);

        Debug.Log($"<color={(decisionResult.isPassed ? "green" : "red")}>RESULT: {decisionResult.decision} (Prob: {prob_pass:P1})</color>");
        Debug.Log($"MSG: {decisionResult.message}");

        // 5. Kirim ke UI
        VRLevelManager uiManager = FindObjectOfType<VRLevelManager>();
        if (uiManager != null)
        {
            // Menggabungkan keputusan utama dengan alasannya untuk ditampilkan ke pemain
            string finalFeedback = $"<b>{decisionResult.decision}</b>\n\n{decisionResult.message}";
            uiManager.ShowLevelCompleteUI(decisionResult.isPassed, prob_pass, finalFeedback);
        }
        else
        {
            Debug.LogError("VRLevelManager tidak ditemukan di scene!");
        }
    }

    // ============================================================
    // THRESHOLD RULE-BASED & RISK CALCULATION
    // ============================================================
    private (bool hardFail, string riskReason) CalculateRisk(double[] features)
    {
        // Urutan array sesuai GetModelFeatureVector() di VRTrainingRecorder.cs
        double level = features[0];
        double velocity = features[1];
        double jerk = features[2];
        double hesitation = features[3];
        double focus = features[4];
        double duration = features[5];

        bool hard_fail = false;
        System.Collections.Generic.List<string> reasons = new System.Collections.Generic.List<string>();

        // 1. Average Hand Velocity
        if (velocity < 0.12) { hard_fail = true; reasons.Add("velocity sangat rendah"); }
        else if (velocity < 0.18) { reasons.Add("velocity rendah"); }
        else if (velocity < 0.22) { reasons.Add("velocity agak rendah"); }

        if (velocity > 0.90) { hard_fail = true; reasons.Add("velocity terlalu tinggi"); }
        else if (velocity > 0.75) { reasons.Add("velocity agak tinggi"); }

        // 2. Max Hand Jerk
        if (jerk > 10000.0) { hard_fail = true; reasons.Add("jerk sangat ekstrem"); }
        else if (jerk >= 5000.0) { reasons.Add("jerk tinggi"); }
        else if (jerk > 3000.0) { reasons.Add("jerk agak tinggi"); }

        // 3. Hesitation Time
        if (hesitation > 450.0) { hard_fail = true; reasons.Add("hesitation sangat tinggi"); }
        else if (hesitation > 300.0) { reasons.Add("hesitation tinggi"); }
        else if (hesitation > 100.0) { reasons.Add("hesitation agak tinggi"); }

        // 4. Focus Consistency
        if (focus > 23.0) { hard_fail = true; reasons.Add("fokus sangat tidak stabil"); }
        else if (focus > 20.0) { reasons.Add("fokus tidak stabil"); }
        else if (focus > 15.0) { reasons.Add("fokus agak tidak stabil"); }

        // 5. Total Duration
        double d_warn = (level == 1) ? 420.0 : 450.0;
        double d_fail = (level == 1) ? 650.0 : 700.0;
        double d_hard_fail = (level == 1) ? 900.0 : 950.0;

        if (duration > d_hard_fail) { hard_fail = true; reasons.Add("durasi sangat lama"); }
        else if (duration > d_fail) { reasons.Add("durasi lama"); }
        else if (duration > d_warn) { reasons.Add("durasi agak lama"); }

        string risk_reason = reasons.Count > 0 ? string.Join(", ", reasons) : "tidak ada risiko";
        
        return (hard_fail, risk_reason);
    }

    // ============================================================
    // LEVELING DECISION (Berdasarkan Tabel 4.11)
    // ============================================================
    private (string decision, string message, bool isPassed) LevelingDecision(double prob_pass, bool hard_fail, string risk_reason)
    {
        if (hard_fail)
        {
            return ("Ulang Level", "Terdapat kondisi ekstrem: " + risk_reason, false);
        }

        if (prob_pass >= 0.80)
        {
            return ("Naik Level", "Probabilitas lulus tinggi.", true);
        }
        else if (prob_pass >= 0.60 && prob_pass < 0.80)
        {
            return ("Naik Level dengan Catatan", "Probabilitas cukup, tetapi tetap perlu memperhatikan catatan performa: " + risk_reason, true);
        }
        else if (prob_pass >= 0.40 && prob_pass < 0.60)
        {
            // Diatur sebagai false agar memunculkan tombol Retry di VRLevelManager (sesuai status "Evaluasi Tambahan")
            return ("Evaluasi Tambahan", "Probabilitas berada pada area tengah sehingga membutuhkan evaluasi tambahan.", false);
        }
        else // prob_pass < 0.40
        {
            return ("Ulang Level", "Probabilitas lulus rendah.", false);
        }
    }
}