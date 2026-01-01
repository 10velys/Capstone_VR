using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables; // Wajib untuk Unity 6

public class MasterLevelController : MonoBehaviour
{
    public static MasterLevelController Instance;

    [Header("Manager Objek (Untuk Hint & Logic)")]
    public GameObject trashManagerObj;
    public GameObject bedManagerObj;
    public GameObject towelManagerObj;

    [Header("Objek Interaktif (Untuk Dikunci/Buka)")]
    // Masukkan semua kertas sampah di sini
    public XRGrabInteractable[] trashObjects;  
    
    // Masukkan semua bantal di sini
    public XRGrabInteractable[] pillowObjects; 
    
    // Masukkan Handuk Kotor (Towel) dan Handuk Bersih (Towel 2) di sini
    public XRGrabInteractable[] towelObjects;  

    void Awake()
    {
        // Setup Singleton
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

// (Bagian Start diperbaiki)
    void Start()
    {
        // === INISIALISASI LEVEL ===
        // Task 1 (Sampah) -> AKTIF
        ActivateTask(trashManagerObj, trashObjects, true);

        // Task 2 (Bantal) -> MATI MUTLAK
        // Pastikan BedManagerObj non-aktif di awal agar Start() dia tidak jalan duluan
        bedManagerObj.SetActive(false); 
        // Kunci fisik objeknya juga
        foreach(var p in pillowObjects) if(p) p.enabled = false;

        // Task 3 (Handuk) -> MATI MUTLAK
        towelManagerObj.SetActive(false);
        foreach(var t in towelObjects) if(t) t.enabled = false;
        
        Debug.Log("Game Mulai: Tahap 1 - Buang Sampah Dimulai!");
    }

    // --- FUNGSI TRANSISI LEVEL ---

    public void FinishTrashTask()
    {
        Debug.Log("MASTER: Sampah Selesai! Membuka Task Bantal...");
        
        // Matikan Sampah
        ActivateTask(trashManagerObj, trashObjects, false);
        
        // Aktifkan Bantal
        ActivateTask(bedManagerObj, pillowObjects, true);
    }

    public void FinishPillowTask()
    {
        Debug.Log("MASTER: Bantal Selesai! Membuka Task Handuk...");

        // Matikan Bantal (Logic Manager dimatikan agar hint hilang, tapi objek bantal biarkan tetap bisa dipegang jika mau, atau dikunci juga boleh)
        // Di sini saya kunci biar rapi sesuai request
        ActivateTask(bedManagerObj, pillowObjects, false); 

        // Aktifkan Handuk
        ActivateTask(towelManagerObj, towelObjects, true);
    }

    public void FinishTowelTask()
    {
        Debug.Log("MASTER: SEMUA TASK SELESAI! LEVEL COMPLETE.");
        
        // Matikan logic handuk terakhir
        if(towelManagerObj != null) towelManagerObj.SetActive(false);
        
        // Di sini bisa panggil UI Menang / Audio Fanfare
    }

    // --- FUNGSI BANTUAN ---
    
    // Fungsi sakti untuk Menyalakan/Mematikan satu paket Task
    void ActivateTask(GameObject manager, XRGrabInteractable[] items, bool isActive)
    {
        // 1. Atur Manager (Ini otomatis menyalakan/mematikan Hint Controller di dalamnya)
        if(manager != null) manager.SetActive(isActive);

        // 2. Atur Interaksi Objek (Bisa di-grab atau tidak)
        foreach (var item in items)
        {
            if (item != null)
            {
                // Kalau false, item jadi pajangan (gak bisa diambil)
                item.enabled = isActive; 
            }
        }
    }
}