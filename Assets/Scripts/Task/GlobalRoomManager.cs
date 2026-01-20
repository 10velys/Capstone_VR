using UnityEngine;
using System.Collections; 
using UnityEngine.SceneManagement; // WAJIB ADA: Untuk pindah scene

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
        if(towelManager) towelManager.ToggleInteraction(false);
        if(towelHintScript) towelHintScript.enabled = false;
        if(towelDiamondObj) towelDiamondObj.SetActive(false);

        // 1. SAVE DATA
        if (VRTrainingRecorder.Instance != null)
        {
            VRTrainingRecorder.Instance.StopAndSave(); 
        }

        // 2. PINDAH LEVEL
        StartCoroutine(LoadNextLevelRoutine());
    }

    IEnumerator LoadNextLevelRoutine()
    {
        Debug.Log("Level Selesai! Loading next scene...");
        yield return new WaitForSeconds(4.0f); // Jeda 4 detik

        if (currentLevelStage == 1)
        {
            SceneManager.LoadScene(level2SceneName);
        }
        else if (currentLevelStage == 2)
        {
            SceneManager.LoadScene(level3SceneName);
        }
        else 
        {
            Debug.Log("Game Tamat! (Level 3 Selesai)");
            // Bisa isi Application.Quit() atau balik ke menu
        }
    }
}