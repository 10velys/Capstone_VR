using UnityEngine;
using System.Collections; 
using UnityEngine.SceneManagement; // WAJIB ADA: Untuk pindah scene
using ML; // WAJIB ADA: Namespace dari script RandomForestModel.cs

public class GlobalRoomManager : MonoBehaviour
{
    [Header("Game Settings")]
    [Tooltip("1 = Full Hint, 2 = No Drop Hint, 3 = Mastery (No Hint)")]
    [Range(1, 3)] public int currentLevelStage = 1; 

    [Header("Scene Management")]
    // Pastikan nama ini SAMA PERSIS dengan nama file scene kamu di folder Project
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
        // Kirim Info Level ke Semua Hint Script saat game mulai
        if(trashHintScript) trashHintScript.SetLevel(currentLevelStage);
        if(bedHintScript) bedHintScript.SetLevel(currentLevelStage);
        if(towelHintScript) towelHintScript.SetLevel(currentLevelStage);

        StartCoroutine(InitSequence());
    }

    IEnumerator InitSequence()
    {
        Debug.Log($"GlobalManager: Starting Level Mode {currentLevelStage}...");
        
        yield return new WaitForSeconds(0.1f);
        DisableAllTasks(); // Kunci semua interaksi di awal
        yield return new WaitForSeconds(1.0f);
        StartTrashTask();
    }

    void DisableAllTasks()
    {
        // Matikan Interaksi (Grab)
        if(trashManager) trashManager.ToggleInteraction(false);
        if(bedManager) bedManager.ToggleInteraction(false);
        if(towelManager) towelManager.ToggleInteraction(false);

        // Matikan Logic Hint
        if(trashHintScript) trashHintScript.enabled = false;
        if(bedHintScript) bedHintScript.enabled = false;
        if(towelHintScript) towelHintScript.enabled = false;

        // Matikan Visual Hint
        if(trashDiamondObj) trashDiamondObj.SetActive(false);
        if(bedDiamondObj) bedDiamondObj.SetActive(false);
        if(towelDiamondObj) towelDiamondObj.SetActive(false);
    }

    // --- PHASE 1: TRASH ---
    void StartTrashTask()
    {
        Debug.Log(">>> PHASE 1 STARTED: TRASH <<<");
        
        // SETUP RECORDER
        if (VRTrainingRecorder.Instance != null)
        {
            VRTrainingRecorder.Instance.current_level = currentLevelStage;
            VRTrainingRecorder.Instance.StartRecording();
        }

        // Buka Kunci Sampah
        if(trashManager) trashManager.ToggleInteraction(true);
        
        // Nyalakan Script Hint (Visualnya nanti diatur sendiri oleh script hint berdasarkan level)
        if(trashHintScript) trashHintScript.enabled = true;      
        if(trashDiamondObj) trashDiamondObj.SetActive(true);      
    }

    public void OnTrashFinished()
    {
        Debug.Log(">>> PHASE 1 COMPLETED <<<");
        
        if(trashManager) trashManager.ToggleInteraction(false); // Kunci lagi sampah
        if(trashHintScript) trashHintScript.enabled = false;      
        if(trashDiamondObj) trashDiamondObj.SetActive(false);     
        
        StartBedTask();
    }

    // --- PHASE 2: BED ---
    void StartBedTask()
    {
        Debug.Log(">>> PHASE 2 STARTED: BED <<<");
        if(bedManager) bedManager.ToggleInteraction(true); // Buka kunci Bantal
        if(bedHintScript) bedHintScript.enabled = true;        
        if(bedDiamondObj) bedDiamondObj.SetActive(true);       
    }

    public void OnBedFinished()
    {
        Debug.Log(">>> PHASE 2 COMPLETED <<<");
        if(bedManager) bedManager.ToggleInteraction(false);
        if(bedHintScript) bedHintScript.enabled = false;       
        if(bedDiamondObj) bedDiamondObj.SetActive(false);      

        StartTowelTask();
    }

    // --- PHASE 3: TOWEL ---
    void StartTowelTask()
    {
        Debug.Log(">>> PHASE 3 STARTED: TOWEL <<<");
        if(towelManager) towelManager.ToggleInteraction(true); // Buka kunci Handuk
        if(towelHintScript) towelHintScript.enabled = true;      
        if(towelDiamondObj) towelDiamondObj.SetActive(true);     
    }

    public void OnTowelFinished()
    {
        Debug.Log(">>> ALL TASKS COMPLETED <<<");
        
        // 1. Matikan Interaksi Handuk & Hint
        if(towelManager) towelManager.ToggleInteraction(false);
        if(towelHintScript) towelHintScript.enabled = false;
        if(towelDiamondObj) towelDiamondObj.SetActive(false);

        // 2. STOP RECORDING & SAVE CSV
        // Kita simpan dulu datanya ke CSV untuk arsip/training ulang nanti
        if (VRTrainingRecorder.Instance != null)
        {
            VRTrainingRecorder.Instance.StopAndSave(); 
        }

        // 3. AI PREDICTION LOGIC
        bool isPassed = false; // Default: Tidak Lulus

        if (VRTrainingRecorder.Instance != null)
        {
            // A. Ambil Data Feature Vector terbaru (Real-time dari memori)
            double[] inputFeatures = VRTrainingRecorder.Instance.GetCurrentFeatureVector();
            
            // B. Minta prediksi ke Random Forest
            // RandomForestModel.Score akan mengembalikan array probabilitas [Prob_Gagal, Prob_Lulus]
            double[] prediction = RandomForestModel.Score(inputFeatures);
            
            // C. Evaluasi Hasil
            // Asumsi: Index 0 = Gagal, Index 1 = Lulus
            if (prediction != null && prediction.Length >= 2)
            {
                // Cek Probabilitas Lulus (Index 1) vs Gagal (Index 0)
                if (prediction[1] > prediction[0]) 
                {
                    isPassed = true;
                    Debug.Log($"<color=green>AI DECISION: PASSED (Confidence: {prediction[1]:F2})</color>");
                }
                else
                {
                    isPassed = false;
                    Debug.Log($"<color=red>AI DECISION: RETRY NEEDED (Confidence: {prediction[0]:F2})</color>");
                }
            }
            else
            {
                Debug.LogWarning("AI Prediction Error: Array null atau length tidak valid.");
            }
        }
        
        // 4. UPDATE UI
        // Panggil UI Manager dan beritahu hasil keputusannya (Lulus/Tidak)
        VRLevelManager uiManager = FindObjectOfType<VRLevelManager>();
        
        if (uiManager != null)
        {
            Debug.Log($"Sending Result to UI: {isPassed}");
            // Pastikan method ShowLevelCompleteUI di VRLevelManager menerima parameter bool!
            uiManager.ShowLevelCompleteUI(isPassed);
        }
        else
        {
            Debug.LogError("VRLevelManager tidak ditemukan di scene!");
        }
    }

    // Fungsi helper untuk pindah level (biasanya dipanggil oleh Button Next di UI Manager)
    // Disimpan di sini jika UI butuh referensi nama scene selanjutnya
    public string GetNextSceneName()
    {
        if (currentLevelStage == 1) return level2SceneName;
        if (currentLevelStage == 2) return level3SceneName;
        return ""; // Game tamat
    }
}