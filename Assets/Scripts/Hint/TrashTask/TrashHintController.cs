using UnityEngine;

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

    void Update()
    {
        if (allCompleted || hintDiamond == null) return;

        // Posisi & Rotasi
        Vector3 targetPos = GetCurrentTargetPosition();
        hintDiamond.transform.position = targetPos;
        hintDiamond.transform.Rotate(0, 50f * Time.deltaTime, 0, Space.World);
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
        if (currentTargetIndex >= trashManager.trashPapers.Length) return;

        Transform currentTarget = trashManager.trashPapers[currentTargetIndex];

        // Cek apakah yang dipegang adalah target saat ini
        if (grabbedObj.transform == currentTarget)
        {
            isHoldingTarget = true;
        }
    }

    public void OnTrashDropped()
    {
        isHoldingTarget = false;
    }

    // --- LOGIC UTAMA (Update untuk Global Manager) ---
    // Menerima parameter 'trashObj' dari BinLogic
    public void OnTaskSuccess(GameObject trashObj)
    {
        // Safety Check
        if (allCompleted || currentTargetIndex >= trashManager.trashPapers.Length) return;

        // Ambil Target Sampah yang SEHARUSNYA sekarang
        Transform currentTarget = trashManager.trashPapers[currentTargetIndex];

        // VALIDASI: Apakah sampah yang masuk Bin adalah sampah target saat ini?
        if (trashObj.transform == currentTarget)
        {
            Debug.Log($"Paper {currentTargetIndex + 1} Benar! Lanjut next.");

            // 1. Reset status pegang
            isHoldingTarget = false;

            // 2. PENTING: Lapor ke TrashManager kalau 1 sampah sudah beres
            // Ini akan memicu GlobalManager jika semua sampah habis
            if (trashManager != null)
            {
                trashManager.CheckTrashProgress();
            }

            // 3. Naikkan Index urutan hint
            currentTargetIndex++;

            // 4. Cek apakah hint sudah tidak diperlukan lagi
            if (currentTargetIndex >= trashManager.trashPapers.Length)
            {
                allCompleted = true;
                hintDiamond.SetActive(false);
                Debug.Log("SEMUA HINT SAMPAH SELESAI!");
            }
        }
        else
        {
            Debug.LogWarning("Sampah masuk, tapi bukan urutannya! Hint tidak berubah.");
        }
    }
}