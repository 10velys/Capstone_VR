using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Interactables; 

public class TowelTaskManager : MonoBehaviour
{
    public GlobalRoomManager globalManager; 

    [Header("Hint System")]
    public TowelHintController hintController;

    [Header("Referensi Objek")]
    public GameObject finalTowel;       
    public GameObject dirtyTowelFolded; 
    
    [Header("Interactables")]
    public XRGrabInteractable dirtyTowelInteractable; 
    public XRGrabInteractable cleanTowelInteractable; 

    [Header("Status Tugas")]
    public bool isDirtyTowelCleared = false;
    public bool isCleanTowelPlaced = false;

    [Header("Safety Settings")]
    public Vector3 taskCenterOffset = new Vector3(10.94f, 0.33f, -77.2f); 
    public float maxDistanceFromTask = 4.0f;

    private Vector3 initialDirtyPos;
    private Quaternion initialDirtyRot;
    private Vector3 initialCleanPos;
    private Quaternion initialCleanRot;

    void Start()
    {
        if (dirtyTowelInteractable != null)
        {
            initialDirtyPos = dirtyTowelInteractable.transform.position;
            initialDirtyRot = dirtyTowelInteractable.transform.rotation;
        }

        if (cleanTowelInteractable != null)
        {
            initialCleanPos = cleanTowelInteractable.transform.position;
            initialCleanRot = cleanTowelInteractable.transform.rotation;
        }

        ToggleInteraction(false);
    }

    void FixedUpdate()
    {
        Vector3 globalCenter = transform.position + taskCenterOffset;

        if (dirtyTowelInteractable != null && !isDirtyTowelCleared && dirtyTowelInteractable.enabled)
        {
            if (!dirtyTowelInteractable.isSelected)
            {
                float dist = Vector3.Distance(globalCenter, dirtyTowelInteractable.transform.position);
                if (dist > maxDistanceFromTask)
                {
                    RespawnTowel(dirtyTowelInteractable, initialDirtyPos, initialDirtyRot);
                }
            }
        }

        if (cleanTowelInteractable != null && !isCleanTowelPlaced && cleanTowelInteractable.enabled)
        {
            if (!cleanTowelInteractable.isSelected)
            {
                float dist = Vector3.Distance(globalCenter, cleanTowelInteractable.transform.position);
                if (dist > maxDistanceFromTask)
                {
                    RespawnTowel(cleanTowelInteractable, initialCleanPos, initialCleanRot);
                }
            }
        }
    }

    void RespawnTowel(XRGrabInteractable towel, Vector3 targetPos, Quaternion targetRot)
    {
        Rigidbody rb = towel.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true;
        }

        towel.transform.position = targetPos;
        towel.transform.rotation = targetRot;

        if (rb != null)
        {
            rb.isKinematic = false;
        }
    }

    public void ToggleInteraction(bool state)
    {
        if (state == true)
        {
            if (dirtyTowelInteractable != null) dirtyTowelInteractable.enabled = true;
            if (cleanTowelInteractable != null) cleanTowelInteractable.enabled = false;
        }
        else
        {
            if (dirtyTowelInteractable != null) dirtyTowelInteractable.enabled = false;
            if (cleanTowelInteractable != null) cleanTowelInteractable.enabled = false;
        }
    }

    public void OnDirtyTowelEnterBasket(GameObject dirtyTowel)
    {
        if (isDirtyTowelCleared) return;
        
        if (hintController != null) hintController.OnDirtyTaskFinished();
        
        Destroy(dirtyTowel);
        
        if (dirtyTowelFolded != null) dirtyTowelFolded.SetActive(true);
        
        isDirtyTowelCleared = true;

        if (cleanTowelInteractable != null) 
        {
            cleanTowelInteractable.enabled = true;
            Debug.Log("Dirty towel cleared. Clean towel unlocked.");
        }
    }

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

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 globalCenter = transform.position + taskCenterOffset;
        Gizmos.DrawWireSphere(globalCenter, maxDistanceFromTask);
    }
}