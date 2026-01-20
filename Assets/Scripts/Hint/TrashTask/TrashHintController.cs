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

    private int currentTargetIndex = 0;
    private bool isHoldingTarget = false;
    private bool allCompleted = false;
    
    // Default Level 1
    private int levelMode = 1; 

    public void SetLevel(int level) { levelMode = level; }

    void Update()
    {
        if (allCompleted || hintDiamond == null) return;

        // LEVEL 3: MATI TOTAL
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
            // LEVEL 1: SELALU NYALA
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
        
        // LEVEL 3: Semua kertas valid
        if (levelMode == 3) { isHoldingTarget = true; return; }

        // LEVEL 1 & 2: Harus sesuai urutan index
        if (currentTargetIndex < trashManager.trashPapers.Length)
        {
            Transform currentTarget = trashManager.trashPapers[currentTargetIndex];
            if (grabbedObj.transform == currentTarget) isHoldingTarget = true;
        }
    }

    public void OnTrashDropped()
    {
        isHoldingTarget = false;
    }

    public void OnTaskSuccess(GameObject trashObj)
    {
        if (allCompleted) return;

        bool isCorrect = false;

        // Validasi berdasarkan level
        if (levelMode == 3) isCorrect = true; // Level 3: Asal masuk tong = benar
        else
        {
            // Level 1 & 2: Cek urutan
            if (currentTargetIndex < trashManager.trashPapers.Length)
            {
                if (trashObj.transform == trashManager.trashPapers[currentTargetIndex]) isCorrect = true;
            }
        }

        if (isCorrect)
        {
            isHoldingTarget = false;
            if (trashManager != null) trashManager.CheckTrashProgress();

            currentTargetIndex++;

            if (currentTargetIndex >= trashManager.trashPapers.Length)
            {
                allCompleted = true;
                hintDiamond.SetActive(false);
            }
        }
    }
}