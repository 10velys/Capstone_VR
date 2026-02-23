using UnityEngine;

public class BedHintController : MonoBehaviour
{
    [Header("Visual")]
    public GameObject hintDiamond;
    public Vector3 offset = new Vector3(0, 0.5f, 0);

    [Header("Referensi Logic")]
    public BedTaskManager bedManager; 

    private int currentTargetIndex = 0;
    private bool isHoldingCurrentPillow = false;
    private bool allTasksCompleted = false;
    private int levelMode = 1; 

    public void SetLevel(int level) { levelMode = level; }

    void Update()
    {
        if (allTasksCompleted || hintDiamond == null) return;

        if (levelMode == 3)
        {
            if (hintDiamond.activeSelf) hintDiamond.SetActive(false);
            return;
        }

        if (levelMode == 2 && isHoldingCurrentPillow)
        {
            if (hintDiamond.activeSelf) hintDiamond.SetActive(false);
        }
        else
        {
            if (!hintDiamond.activeSelf) hintDiamond.SetActive(true);
            
            Vector3 targetPos = CalculateTargetPosition();
            hintDiamond.transform.position = targetPos;
            hintDiamond.transform.Rotate(0, 50f * Time.deltaTime, 0, Space.World);
        }
    }

    Vector3 CalculateTargetPosition()
    {
        if (currentTargetIndex >= 4) return hintDiamond.transform.position;

        if (isHoldingCurrentPillow)
        {
            return bedManager.pillowTargetZones[currentTargetIndex].transform.position + offset;
        }
        else
        {
            Transform targetPillow = GetPillowByIndex(currentTargetIndex);
            if (targetPillow != null) return targetPillow.transform.position + offset;
        }
        return hintDiamond.transform.position;
    }

    Transform GetPillowByIndex(int index)
    {
        if (bedManager == null) return null;
        switch (index)
        {
            case 0: return bedManager.pillow1 != null ? bedManager.pillow1.transform : null;
            case 1: return bedManager.pillow2 != null ? bedManager.pillow2.transform : null;
            case 2: return bedManager.pillow3 != null ? bedManager.pillow3.transform : null;
            case 3: return bedManager.pillow4 != null ? bedManager.pillow4.transform : null;
            default: return null;
        }
    }

    public void OnPillowGrabbed(GameObject grabbedObj)
    {
        if (levelMode == 3)
        {
            isHoldingCurrentPillow = true;
            return;
        }

        Transform targetPillow = GetPillowByIndex(currentTargetIndex);
        if (targetPillow != null && grabbedObj.transform == targetPillow)
        {
            isHoldingCurrentPillow = true;
        }
    }

    public void OnPillowDropped()
    {
        isHoldingCurrentPillow = false;
    }

    public void OnPillowPlacedSuccess(int placedIndex)
    {
        isHoldingCurrentPillow = false;
        currentTargetIndex++;
        
        if (currentTargetIndex >= 4) 
        {
            allTasksCompleted = true;
            if (hintDiamond != null) hintDiamond.SetActive(false);
        }
    }
}