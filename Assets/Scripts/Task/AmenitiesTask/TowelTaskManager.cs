using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables; // Pastikan namespace ini ada untuk Unity 6/XRI terbaru

public class TowelTaskManager : MonoBehaviour
{
    public GlobalRoomManager globalManager; 

    [Header("Hint System")]
    public TowelHintController hintController;

    [Header("Referensi Objek")]
    public GameObject finalTowel;       
    public GameObject dirtyTowelFolded; 
    
    [Header("Interactables")]
    // Referensi ke komponen grab agar kita bisa nyalakan/matikan
    public XRGrabInteractable dirtyTowelInteractable; 
    public XRGrabInteractable cleanTowelInteractable; 

    [Header("Status Tugas")]
    public bool isDirtyTowelCleared = false;
    public bool isCleanTowelPlaced = false;

    void Start()
    {
        // Matikan interaksi handuk di awal (Tunggu perintah Global)
        // Kirim false untuk mematikan keduanya
        ToggleInteraction(false);
    }

    public void ToggleInteraction(bool state)
    {
        if (state == true)
        {
            // --- LOGIKA BARU: URUTAN SEKUENSIAL ---
            // Saat tugas dimulai (state = true), HANYA nyalakan handuk kotor.
            // Handuk bersih tetap mati sampai handuk kotor selesai.
            if (dirtyTowelInteractable != null) dirtyTowelInteractable.enabled = true;
            if (cleanTowelInteractable != null) cleanTowelInteractable.enabled = false;
        }
        else
        {
            // Jika state = false (Tugas belum mulai / selesai), matikan semua
            if (dirtyTowelInteractable != null) dirtyTowelInteractable.enabled = false;
            if (cleanTowelInteractable != null) cleanTowelInteractable.enabled = false;
        }
    }

    // Dipanggil oleh TowelSensor saat handuk kotor masuk keranjang
    public void OnDirtyTowelEnterBasket(GameObject dirtyTowel)
    {
        if (isDirtyTowelCleared) return;
        
        if (hintController != null) hintController.OnDirtyTaskFinished();
        
        // Hancurkan handuk kotor fisik
        Destroy(dirtyTowel);
        
        // Munculkan visual tumpukan handuk kotor
        if (dirtyTowelFolded != null) dirtyTowelFolded.SetActive(true);
        
        isDirtyTowelCleared = true;

        // --- TAMBAHAN: Buka Kunci Handuk Bersih ---
        // Sekarang user baru boleh mengambil handuk bersih
        if (cleanTowelInteractable != null) 
        {
            cleanTowelInteractable.enabled = true;
            Debug.Log("Dirty towel cleared. Clean towel unlocked.");
        }
    }

    // Dipanggil oleh TowelSensor saat handuk bersih masuk rak
    public void OnCleanTowelEnterRack(GameObject cleanTowel)
    {
    if (isCleanTowelPlaced) return;

    if (hintController != null) hintController.OnCleanTaskFinished();
    
    Destroy(cleanTowel);
    if (finalTowel != null) finalTowel.SetActive(true);
    isCleanTowelPlaced = true;

    if (VRTrainingRecorder.Instance != null)
    {
        VRTrainingRecorder.Instance.MarkTowelCompleted();
    }
    
    if (globalManager != null) globalManager.OnTowelFinished();
}
}