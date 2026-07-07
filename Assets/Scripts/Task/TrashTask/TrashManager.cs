using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Interactables; 

public class TrashManager : MonoBehaviour
{
    [Header("Global Manager Reference")]
    public GlobalRoomManager globalManager;

    [Header("Daftar Sampah")]
    public Transform[] trashPapers; 

    [Header("Area Random Spawn")]
    public Vector2 randomAreaSize = new Vector2(2f, 2f); 

    [Header("Safety Settings")]
    public float maxDistanceFromBin = 5.0f;

    private int collectedCount = 0;
    private int totalTrash = 0;
    private List<XRGrabInteractable> trashInteractables = new List<XRGrabInteractable>();

    void Awake()
    {
        trashInteractables.Clear();
        if (trashPapers != null)
        {
            foreach (Transform t in trashPapers)
            {
                if (t != null)
                {
                    var grab = t.GetComponent<XRGrabInteractable>();
                    if (grab != null) trashInteractables.Add(grab);
                }
            }
        }
    }

    void Start()
    {
        if (trashPapers == null) trashPapers = new Transform[0];
        totalTrash = trashPapers.Length;
        
        foreach (Transform t in trashPapers)
        {
            if (t == null) continue;
            
            Rigidbody rb = t.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.isKinematic = false; 
                rb.useGravity = true;
            }
        }

        ScatterTrash();
    }

    void FixedUpdate()
    {
        if (globalManager != null && globalManager.trashDiamondObj.activeSelf == false && collectedCount >= totalTrash) return;

        foreach (Transform paper in trashPapers)
        {
            if (paper != null && paper.gameObject.activeSelf)
            {
                var grab = paper.GetComponent<XRGrabInteractable>();
                if (grab != null && !grab.isSelected && grab.enabled)
                {
                    float dist = Vector3.Distance(transform.position, paper.position);
                    if (dist > maxDistanceFromBin)
                    {
                        RespawnSingleTrash(paper);
                    }
                }
            }
        }
    }

    void RespawnSingleTrash(Transform paper)
    {
        Rigidbody rb = paper.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true;
        }

        float randomX = Random.Range(-randomAreaSize.x / 4, randomAreaSize.x / 4);
        float randomZ = Random.Range(-randomAreaSize.y / 4, randomAreaSize.y / 4);
        
        Vector3 safePos = new Vector3(
            transform.position.x + randomX,
            transform.position.y + 0.3f,
            transform.position.z + randomZ
        );

        paper.position = safePos;
        paper.rotation = Random.rotation;

        if (rb != null)
        {
            rb.isKinematic = false;
        }
    }

    void ScatterTrash()
    {
        foreach (Transform paper in trashPapers)
        {
            if (paper == null) continue;

            float randomX = Random.Range(-randomAreaSize.x / 2, randomAreaSize.x / 2);
            float randomZ = Random.Range(-randomAreaSize.y / 2, randomAreaSize.y / 2);

            Vector3 newPos = new Vector3(
                transform.position.x + randomX,
                transform.position.y + 0.5f, 
                transform.position.z + randomZ
            );

            paper.position = newPos;
            paper.rotation = Random.rotation;
        }
    }

    public void ToggleInteraction(bool state)
    {
        foreach (var interactable in trashInteractables)
        {
            if (interactable == null) continue;
            interactable.enabled = state; 
            
            Rigidbody rb = interactable.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false; 
            }
        }
        
        Debug.Log($"Trash Interaction set to: {state}");
    }

    public void CheckTrashProgress()
    {
        collectedCount++;
        Debug.Log($"Sampah Terkumpul: {collectedCount}/{totalTrash}");
        
        if (collectedCount >= totalTrash)
        {
            Debug.Log("SEMUA SAMPAH SELESAI!");

            if (VRTrainingRecorder.Instance != null)
            {
                VRTrainingRecorder.Instance.MarkTrashCompleted();
            }   

            if (globalManager != null) 
            {
                globalManager.OnTrashFinished();
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, maxDistanceFromBin);
    }
}