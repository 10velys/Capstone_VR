using UnityEngine;
using System.Collections.Generic; // WAJIB ADA: Untuk pakai List

public class TrashHintController : MonoBehaviour
{
    [Header("Referensi Visual")]
    public GameObject hintDiamond;

    [Header("Referensi Logika")]
    public TrashManager trashManager;
    public Transform binTarget;

    [Header("Posisi Offset")]
    public Vector3 offset = new Vector3(0, 0.3f, 0);

    // Variable Internal
    private int currentTargetIndex = 0;
    private bool isHoldingTarget = false;
    private bool allCompleted = false;
    
    // Default Level 1
    private int levelMode = 1; 
    
    // --- TAMBAHAN BARU UNTUK LEVEL 3 ---
    // List untuk menyimpan sampah mana saja yang SUDAH masuk (agar tidak double count)
    private List<GameObject> processedTrashObjects = new List<GameObject>();

    public void SetLevel(int level) 
    { 
        levelMode = level; 
        // Reset list saat level diset
        processedTrashObjects.Clear();
    }

    void Update()
    {
        if (allCompleted || hintDiamond == null) return;

        // LEVEL 3: MATI TOTAL (MASTERY)
        if (levelMode == 3)
        {
            if (hintDiamond.activeSelf) hintDiamond.SetActive(false);
            return; 
        }

        // LEVEL 2: MATI SAAT PEGANG BARANG (Cari sendiri tong sampahnya)
        if (levelMode == 2 && isHoldingTarget)
        {
            if (hintDiamond.activeSelf) hintDiamond.SetActive(false);
        }
        else
        {
            // LEVEL 1: SELALU NYALA (FULL ASSIST)
            if (!hintDiamond.activeSelf) hintDiamond.SetActive(true);
            
            Vector3 targetPos = GetCurrentTargetPosition();
            hintDiamond.transform.position = targetPos;
            hintDiamond.transform.Rotate(0, 50f * Time.deltaTime, 0, Space.World);
        }
    }

    Vector3 GetCurrentTargetPosition()
    {
        if (isHoldingTarget)
        {
            if (binTarget != null) return binTarget.position + offset;
        }

        if (currentTargetIndex < trashManager.trashPapers.Length)
        {
            Transform targetTrash = trashManager.trashPapers[currentTargetIndex];
            if (targetTrash != null) return targetTrash.position + offset;
        }

        return hintDiamond.transform.position;
    }

    public void OnTrashGrabbed(GameObject grabbedObj)
    {
        if (allCompleted) return;
        
        // LEVEL 3: Semua kertas valid, ASALKAN belum pernah dibuang sebelumnya
        if (levelMode == 3) 
        { 
            // Cek apakah sampah ini sudah ada di list "Selesai"
            if (!processedTrashObjects.Contains(grabbedObj))
            {
                isHoldingTarget = true; 
            }
            return;
        }

        // LEVEL 1 & 2: Harus sesuai urutan index
        if (currentTargetIndex < trashManager.trashPapers.Length)
        {
            Transform currentTarget = trashManager.trashPapers[currentTargetIndex];
            if (grabbedObj.transform == currentTarget)
            {
                isHoldingTarget = true;
            }
        }
    }

    public void OnTrashDropped()
    {
        isHoldingTarget = false;
    }

    // --- LOGIC UTAMA YANG DIPERBAIKI ---
    public void OnTaskSuccess(GameObject trashObj)
    {
        if (allCompleted) return;

        bool isCorrect = false;

        // --- LOGIKA LEVEL 3 (FIXED) ---
        if (levelMode == 3)
        {
            // 1. Cek apakah sampah ini SUDAH pernah dicatat masuk?
            if (processedTrashObjects.Contains(trashObj)) 
            {
                Debug.LogWarning("Sampah ini terdeteksi ganda! Diabaikan.");
                return; // JANGAN PROSES LAGI
            }

            // 2. Jika belum, tandanya ini sampah baru yang valid
            processedTrashObjects.Add(trashObj); // Catat sampah ini
            isCorrect = true;
        }
        // --- LOGIKA LEVEL 1 & 2 ---
        else
        {
            // Cek urutan array (Strict)
            if (currentTargetIndex < trashManager.trashPapers.Length)
            {
                if (trashObj.transform == trashManager.trashPapers[currentTargetIndex]) 
                {
                    isCorrect = true;
                }
            }
        }

        // --- EKSEKUSI JIKA BENAR ---
        if (isCorrect)
        {
            Debug.Log($"Sampah Valid Masuk! (Level {levelMode})");
            isHoldingTarget = false;

            // PENTING: Lapor ke TrashManager untuk update progress bar / cek finish
            if (trashManager != null)
            {
                trashManager.CheckTrashProgress();
            }

            // Naikkan index internal hint (untuk Level 1 & 2)
            // Untuk Level 3, ini berfungsi sebagai counter jumlah sampah yang sudah masuk
            currentTargetIndex++;

            // Cek apakah jumlah sampah yang masuk sudah sama dengan total sampah yang ada
            if (currentTargetIndex >= trashManager.trashPapers.Length)
            {
                allCompleted = true;
                hintDiamond.SetActive(false);
                Debug.Log("SEMUA SAMPAH SELESAI!");
            }
        }
        else
        {
             Debug.LogWarning("Sampah masuk tapi tidak valid (Salah urutan atau duplikat).");
        }
    }
}