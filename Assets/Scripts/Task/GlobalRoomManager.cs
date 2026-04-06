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

        // 3. AI prediction
        double[] prediction = null;
        double prob_pass = 0.0;

        if (VRTrainingRecorder.Instance != null)
        {
            // Ambil 6 fitur khusus model
            double[] rawFeatures = VRTrainingRecorder.Instance.GetModelFeatureVector();

            // Standardisasi dulu sebelum scoring
            double[] scaledFeatures = RandomForestModel.Standardize(rawFeatures);

            // Debug agar mudah dibandingkan dengan Python
            Debug.Log(
                $"RAW FEATURES => level={rawFeatures[0]:F4}, " +
                $"avg_vel={rawFeatures[1]:F4}, jerk={rawFeatures[2]:F4}, " +
                $"hes={rawFeatures[3]:F4}, focus={rawFeatures[4]:F4}, dur={rawFeatures[5]:F4}"
            );

            Debug.Log(
                $"SCALED FEATURES => level={scaledFeatures[0]:F4}, " +
                $"avg_vel={scaledFeatures[1]:F4}, jerk={scaledFeatures[2]:F4}, " +
                $"hes={scaledFeatures[3]:F4}, focus={scaledFeatures[4]:F4}, dur={scaledFeatures[5]:F4}"
            );

            prediction = RandomForestModel.Score(scaledFeatures);

            if (prediction != null && prediction.Length >= 2)
            {
                // Asumsi index 1 = probabilitas LULUS
                prob_pass = prediction[1];
                Debug.Log($"AI Raw Score: Fail={prediction[0]:F4}, Pass={prediction[1]:F4}");
            }
            else
            {
                Debug.LogError("Prediction null atau format output model tidak valid.");
            }
        }
        else
        {
            Debug.LogError("VRTrainingRecorder.Instance tidak ditemukan.");
        }

        // 4. Logic feedback
        string feedbackMsg = "";

        if (prob_pass >= 0.90)
        {
            feedbackMsg = "Luar biasa! Motorikmu sangat stabil dan fokusmu sempurna.";
        }
        else if (prob_pass >= 0.70)
        {
            feedbackMsg = "Bagus! Kamu lulus. Cobalah untuk sedikit lebih halus dalam bergerak.";
        }
        else if (prob_pass >= 0.50)
        {
            feedbackMsg = "Kamu lulus, tapi kamu tampak banyak ragu-ragu.";
        }
        else if (prob_pass >= 0.30)
        {
            feedbackMsg = "Hampir saja! Fokuslah pada penyelesaian tugas.";
        }
        else
        {
            feedbackMsg = "Ayo berlatih lagi. Fokuslah pada satu tugas sampai selesai.";
        }

        // 5. Tentukan status lulus/gagal
        bool isPassed = (prob_pass >= 0.50);

        Debug.Log($"<color={(isPassed ? "green" : "red")}>RESULT: {isPassed} (Score: {prob_pass:P1})</color>");
        Debug.Log($"MSG: {feedbackMsg}");

        // 6. Kirim ke UI
        VRLevelManager uiManager = FindObjectOfType<VRLevelManager>();

        if (uiManager != null)
        {
            uiManager.ShowLevelCompleteUI(isPassed, prob_pass, feedbackMsg);
        }
        else
        {
            Debug.LogError("VRLevelManager tidak ditemukan di scene!");
        }
    }

    public string GetNextSceneName()
    {
        if (currentLevelStage == 1) return level2SceneName;
        if (currentLevelStage == 2) return level3SceneName;
        return "";
    }
}