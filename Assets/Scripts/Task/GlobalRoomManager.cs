using UnityEngine;
using System.Collections; // Butuh ini untuk IEnumerator

public class GlobalRoomManager : MonoBehaviour
{
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
        // PENTING: Jangan langsung matikan di detik ke-0.
        // Biarkan semua script 'Start' berjalan dulu (termasuk Auto-Fix collider di TrashManager).
        // Kita gunakan Coroutine untuk mengatur urutan loading.
        StartCoroutine(InitSequence());
    }

    IEnumerator InitSequence()
    {
        Debug.Log("GlobalManager: Menunggu inisialisasi script lain...");
        
        // 1. Tunggu 0.1 detik agar TrashManager.Start() selesai dijalankan Unity
        yield return new WaitForSeconds(0.1f);

        // 2. Matikan SEMUA Interaksi & Hint
        Debug.Log("GlobalManager: Reset All Tasks...");
        DisableAllTasks();

        // 3. Tunggu lagi sebentar (1 detik) biar fisika stabil
        yield return new WaitForSeconds(1.0f);

        // 4. Mulai Task Pertama
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
        
        // Pastikan TrashManager ada
        if(trashManager != null) 
        {
            trashManager.ToggleInteraction(true); // Panggil fungsi enable
        }
        else 
        {
            Debug.LogError("TrashManager belum dimasukkan ke Inspector GlobalRoomManager!");
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
        
        // Lanjut Phase 2
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
    }
}