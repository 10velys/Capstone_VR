using UnityEngine;

// using UnityEngine.XR.Interaction.Toolkit.Interactables; // Unity 6

public class TowelTaskManager : MonoBehaviour
{
    public GlobalRoomManager globalManager; // <--- REFERENSI KE GLOBAL

    [Header("Hint System")]
    public TowelHintController hintController;

    [Header("Referensi Objek")]
    public GameObject finalTowel;       
    public GameObject dirtyTowelFolded; 
    
    // TAMBAHAN: Referensi Handuk Kotor & Handuk Bersih (Untuk dimatikan interaksinya)
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable dirtyTowelInteractable; // Drag handuk kotor disini
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable cleanTowelInteractable; // Drag handuk bersih di keranjang disini

    [Header("Status Tugas")]
    public bool isDirtyTowelCleared = false;
    public bool isCleanTowelPlaced = false;

    void Start()
    {
        // Matikan interaksi handuk di awal (Tunggu perintah Global)
        ToggleInteraction(false);
    }

    public void ToggleInteraction(bool state)
    {
        if (dirtyTowelInteractable != null) dirtyTowelInteractable.enabled = state;
        if (cleanTowelInteractable != null) cleanTowelInteractable.enabled = state;
    }

    // ... (OnDirtyTowelEnterBasket TETAP SAMA) ...
    public void OnDirtyTowelEnterBasket(GameObject dirtyTowel)
    {
        if (isDirtyTowelCleared) return;
        
        if (hintController != null) hintController.OnDirtyTaskFinished();
        Destroy(dirtyTowel);
        if (dirtyTowelFolded != null) dirtyTowelFolded.SetActive(true);
        isDirtyTowelCleared = true;
    }

    // ... (OnCleanTowelEnterRack TETAP SAMA, TAMBAH Lapor Global) ...
    public void OnCleanTowelEnterRack(GameObject cleanTowel)
    {
        if (isCleanTowelPlaced) return;

        if (hintController != null) hintController.OnCleanTaskFinished();
        Destroy(cleanTowel);
        if (finalTowel != null) finalTowel.SetActive(true);
        isCleanTowelPlaced = true;
        
        // TAMBAHAN: Lapor Selesai ke Global
        if (globalManager != null) globalManager.OnTowelFinished();
    }
}