using UnityEngine;
using System.Collections; 

public class GlobalRoomManager : MonoBehaviour
{
    [Header("Game Settings")]
    [Tooltip("Isi dengan 1, 2, atau 3 sesuai Scene Level ini")]
    [Range(1, 3)] public int currentLevelStage = 1; // Diganti namanya agar lebih jelas

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
        StartCoroutine(InitSequence());
    }

    IEnumerator InitSequence()
    {
        Debug.Log("GlobalManager: Menunggu inisialisasi script lain...");
        
        yield return new WaitForSeconds(0.1f);

        Debug.Log("GlobalManager: Reset All Tasks...");
        DisableAllTasks();

        yield return new WaitForSeconds(1.0f);

        StartTrashTask();
    }

    void DisableAllTasks()
    {
        // Matikan Interaksi
        if(trashManager) trashManager.ToggleInteraction(false);
        if(bedManager) bedManager.ToggleInteraction(false);
        if(towelManager) towelManager.ToggleInteraction(false);

        // Matikan Hint Logic
        if(trashHintScript) trashHintScript.enabled = false;
        if(bedHintScript) bedHintScript.enabled = false;
        if(towelHintScript) towelHintScript.enabled = false;

        // Matikan Visual
        if(trashDiamondObj) trashDiamondObj.SetActive(false);
        if(bedDiamondObj) bedDiamondObj.SetActive(false);
        if(towelDiamondObj) towelDiamondObj.SetActive(false);
    }

    // --- PHASE 1: TRASH ---
    void StartTrashTask()
    {
        Debug.Log(">>> PHASE 1 STARTED: TRASH <<<");
        
        // --- INTEGRASI RECORDER ---
        if (VRTrainingRecorder.Instance != null)
        {
            // 1. Kirim Info Level (1/2/3) ke Recorder untuk Data CSV
            VRTrainingRecorder.Instance.current_level = currentLevelStage;

            // 2. Mulai Recording (Logic baru: Reset memori & Timer)
            VRTrainingRecorder.Instance.StartRecording();
        }
        else
        {
            Debug.LogWarning("VRTrainingRecorder tidak ditemukan di Scene!");
        }
        // -------------------------

        if(trashManager != null) 
        {
            trashManager.ToggleInteraction(true); 
        }
        
        if(trashHintScript) trashHintScript.enabled = true;      
        if(trashDiamondObj) trashDiamondObj.SetActive(true);      
    }

    public void OnTrashFinished()
    {
        Debug.Log(">>> PHASE 1 COMPLETED <<<");
        
        if(trashManager) trashManager.ToggleInteraction(false);
        if(trashHintScript) trashHintScript.enabled = false;      
        if(trashDiamondObj) trashDiamondObj.SetActive(false);     
        
        StartBedTask();
    }

    // --- PHASE 2: BED ---
    void StartBedTask()
    {
        Debug.Log(">>> PHASE 2 STARTED: BED <<<");
        if(bedManager) bedManager.ToggleInteraction(true);
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
        if(towelManager) towelManager.ToggleInteraction(true);
        if(towelHintScript) towelHintScript.enabled = true;      
        if(towelDiamondObj) towelDiamondObj.SetActive(true);     
    }

    public void OnTowelFinished()
    {
        Debug.Log(">>> ALL TASKS COMPLETED <<<");
        if(towelManager) towelManager.ToggleInteraction(false);
        if(towelHintScript) towelHintScript.enabled = false;
        if(towelDiamondObj) towelDiamondObj.SetActive(false);

        // --- STOP RECORDER & SAVE ---
        if (VRTrainingRecorder.Instance != null)
        {
            // Panggil fungsi Save (Method ini otomatis melakukan kalkulasi agregasi & tulis CSV)
            VRTrainingRecorder.Instance.StopAndSave(); 
        }
    }
}