using UnityEngine;

public class TowelHintController : MonoBehaviour
{
    [Header("Visual")]
    public GameObject hintDiamond;
    public Vector3 offset = new Vector3(0, 0.3f, 0);

    [Header("Referensi Objek")]
    public Transform dirtyTowelTarget;
    public Transform basketTarget;
    public Transform cleanTowelTarget;
    public Transform rackTarget;

    private int currentStep = 0; 
    private bool isHoldingTowel = false;
    private int levelMode = 1;

    public void SetLevel(int level) { levelMode = level; }

    void Update()
    {
        if (currentStep >= 2 || hintDiamond == null) return;

        if (levelMode == 3)
        {
            if (hintDiamond.activeSelf) hintDiamond.SetActive(false);
            return;
        }

        if (levelMode == 2 && isHoldingTowel)
        {
            if (hintDiamond.activeSelf) hintDiamond.SetActive(false);
        }
        else
        {
            if (!hintDiamond.activeSelf) hintDiamond.SetActive(true);

            Vector3 targetPos = CalculatePosition();
            hintDiamond.transform.position = targetPos;
            hintDiamond.transform.Rotate(0, 50f * Time.deltaTime, 0, Space.World);
        }
    }

    Vector3 CalculatePosition()
    {
        if (currentStep == 0) // Kotor
        {
            if (isHoldingTowel) return basketTarget.position + offset;
            else if (dirtyTowelTarget != null) return dirtyTowelTarget.position + offset;
        }
        else if (currentStep == 1) // Bersih
        {
            if (isHoldingTowel) return rackTarget.position + offset;
            else if (cleanTowelTarget != null) return cleanTowelTarget.position + offset;
        }
        return hintDiamond.transform.position; 
    }

    public void OnTowelGrabbed(GameObject grabbedObj)
    {
        // Cek Transform saja
        if (currentStep == 0 && grabbedObj.transform == dirtyTowelTarget) isHoldingTowel = true;
        else if (currentStep == 1 && grabbedObj.transform == cleanTowelTarget) isHoldingTowel = true;
    }

    public void OnTowelDropped() { isHoldingTowel = false; }

    public void OnDirtyTaskFinished()
    {
        isHoldingTowel = false;
        currentStep = 1; 
    }

    public void OnCleanTaskFinished()
    {
        isHoldingTowel = false;
        currentStep = 2; 
        hintDiamond.SetActive(false);
    }
}