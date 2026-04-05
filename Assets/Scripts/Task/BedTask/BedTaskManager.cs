using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;
using System.Collections.Generic;

public enum BedTaskState
{
    TidyPillows,
    TaskComplete
}

public class BedTaskManager : MonoBehaviour
{
    [Header("Global Manager")]
    public GlobalRoomManager globalManager;

    [Header("Hint System")]
    public BedHintController hintController;

    [Header("Task State")]
    public BedTaskState currentState;

    [Header("Task Objects (Interactables)")]
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow1;
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow2;
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow3;
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow4;

    [Header("Task Zones (Triggers)")]
    public Collider[] pillowTargetZones;

    [Header("Randomization Area")]
    public Vector3 pillowMessyCenterOffset;
    public Vector3 pillowMessySize = new Vector3(1.5f, 0.2f, 1);
    [Range(0, 90)]
    public float maxMessyTilt = 20f;
   
    [Header("Task Settings")]
    public float placementPrecision = 0.4f;
    
    [Header("Safety Settings")]
    public float maxDistanceFromBed = 3.0f;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] allPillows;
    private bool[] pillowIsPlaced;

    void Start()
    {
        allPillows = new UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] { pillow1, pillow2, pillow3, pillow4 };

        if (allPillows.Length != pillowTargetZones.Length) Debug.LogError("Setup Error: Jumlah bantal tidak sesuai!");
       
        StartCoroutine(SpawnPillowsSafely());
        InitializePillowTask();
        ToggleInteraction(false);
    }

    public void ToggleInteraction(bool state)
    {
        foreach (var pillow in allPillows)
        {
            if (pillow != null)
            {
                pillow.enabled = state; 
            }
        }
    }

    void FixedUpdate()
    {
        if (currentState != BedTaskState.TidyPillows) return;

        foreach (var pillow in allPillows)
        {
            if (pillow != null && pillow.enabled)
            {
                float dist = Vector3.Distance(transform.position + pillowMessyCenterOffset, pillow.transform.position);
                
                if (dist > maxDistanceFromBed) 
                {
                    RespawnSinglePillow(pillow);
                }
            }
        }
    }

    void RespawnSinglePillow(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow)
    {
        Rigidbody rb = pillow.GetComponent<Rigidbody>();
        if(rb)
        {
            rb.linearVelocity = Vector3.zero; 
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true; 
        }

        Vector3 safePos = transform.position + pillowMessyCenterOffset + (Vector3.up * 0.6f); 
        pillow.transform.position = safePos;
        pillow.transform.rotation = Quaternion.identity;

        StartCoroutine(GentlyDropPillow(rb));
    }

    IEnumerator SpawnPillowsSafely()
    {
        foreach (var pillow in allPillows)
        {
            if (pillow == null) continue;
            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true; 
                rb.detectCollisions = false;
            }
        }

        yield return new WaitForEndOfFrame();

        foreach (var pillow in allPillows)
        {
            if (pillow == null) continue;

            Vector3 finalPos = Vector3.zero;
            bool positionFound = false;
            int attempts = 0;
            
            BoxCollider col = pillow.GetComponent<BoxCollider>();
            Vector3 checkSize = col != null ? col.size * 0.55f : Vector3.one * 0.2f; 

            while (!positionFound && attempts < 30)
            {
                Vector3 candidatePos = GetRandomPositionInVirtualBox(pillowMessyCenterOffset, pillowMessySize);
                candidatePos.y = transform.position.y + pillowMessyCenterOffset.y + 0.3f; 

                Collider[] hitColliders = Physics.OverlapBox(candidatePos, checkSize, Quaternion.identity);
                
                bool hitSomethingImportant = false;
                foreach(var hit in hitColliders)
                {
                    if (hit.isTrigger || hit.transform == pillow.transform) continue;
                    hitSomethingImportant = true;
                    break;
                }

                if (!hitSomethingImportant)
                {
                    finalPos = candidatePos;
                    positionFound = true;
                }
                attempts++;
            }

            if (!positionFound) 
            {
                finalPos = transform.position + pillowMessyCenterOffset + (Vector3.up * (0.3f + (allPillows.Length * 0.2f)));
            }

            pillow.transform.position = finalPos;
            float pillowY_Rotation = Random.Range(0f, 360f);
            pillow.transform.rotation = Quaternion.Euler(0, pillowY_Rotation, 0); 
        }

        yield return new WaitForSeconds(0.1f);

        foreach (var pillow in allPillows)
        {
            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.detectCollisions = true;
                rb.isKinematic = false;
                rb.linearDamping = 10f; 
                rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            }
        }

        yield return new WaitForSeconds(2.0f);
        
        foreach (var pillow in allPillows)
        {
            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearDamping = 0f;
            }
        }
    }

    IEnumerator GentlyDropPillow(Rigidbody rb)
    {
        if(rb == null) yield break;
        
        rb.detectCollisions = true;
        rb.isKinematic = false;
        rb.linearDamping = 10f;
        yield return new WaitForSeconds(1.5f);
        rb.linearDamping = 0f;
    }

    Vector3 GetRandomPositionInVirtualBox(Vector3 centerOffset, Vector3 size)
    {
        Vector3 worldCenter = transform.position + centerOffset;
        Vector3 min = worldCenter - size / 2;
        Vector3 max = worldCenter + size / 2;
        return new Vector3(
            Random.Range(min.x, max.x),
            Random.Range(min.y, max.y),
            Random.Range(min.z, max.z)
        );
    }

    void InitializePillowTask()
    {
        currentState = BedTaskState.TidyPillows;
        pillowIsPlaced = new bool[allPillows.Length];
       
        foreach (var pillow in allPillows)
        {
            if (pillow != null)
            {
                pillow.selectExited.AddListener(CheckPillowPlacement);
            }
        }
    }

    private void CheckPillowPlacement(SelectExitEventArgs arg0)
    {
        if (currentState != BedTaskState.TidyPillows) return;

        var grabbedPillow = arg0.interactableObject.transform.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        if (grabbedPillow == null) return;

        Collider pillowCollider = grabbedPillow.GetComponent<Collider>();
        int pillowIndex = System.Array.IndexOf(allPillows, grabbedPillow);
        int level = (globalManager != null) ? globalManager.currentLevelStage : 1;

        if (level == 1)
        {
            if (pillowIndex != -1 && !pillowIsPlaced[pillowIndex])
            {
                Collider targetZone = pillowTargetZones[pillowIndex];
                if (CheckFit(pillowCollider, targetZone))
                {
                    ApplyPlacement(grabbedPillow, targetZone, pillowIndex);
                }
            }
        }
        else
        {
            bool isLargePillow = (pillowIndex == 0 || pillowIndex == 1);

            for (int j = 0; j < pillowTargetZones.Length; j++)
            {
                if (pillowIsPlaced[j]) continue;

                bool isTargetForLarge = (j == 0 || j == 1);
                if (isLargePillow != isTargetForLarge) continue;

                Collider targetZone = pillowTargetZones[j];
                if (CheckFit(pillowCollider, targetZone))
                {
                    ApplyPlacement(grabbedPillow, targetZone, j);
                    break;
                }
            }
        }

        CheckAllTasksComplete();
    }

    private bool CheckFit(Collider pillow, Collider zone)
    {
        bool isOverlapping = zone.bounds.Intersects(pillow.bounds);
        float centerDistance = Vector3.Distance(pillow.bounds.center, zone.bounds.center);
        return isOverlapping && centerDistance <= placementPrecision;
    }

    private void ApplyPlacement(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow, Collider zone, int index)
    {
        pillow.transform.position = zone.transform.position;
        pillow.transform.rotation = zone.transform.rotation;
        
        Rigidbody rb = pillow.GetComponent<Rigidbody>();
        if(rb)
        {
            rb.isKinematic = true;
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        pillowIsPlaced[index] = true;
        LockPillow(pillow);
        if (hintController != null) hintController.OnPillowPlacedSuccess(index);
    }

    private void CheckAllTasksComplete()
    {
        int successCount = 0;
        foreach (bool placed in pillowIsPlaced) if (placed) successCount++;

        if (successCount == allPillows.Length)
        {
            CompletePillowTask();
            if (globalManager != null) globalManager.OnBedFinished();
        }
    }

    void LockPillow(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow)
    {
        pillow.enabled = false;
        pillow.selectExited.RemoveListener(CheckPillowPlacement);
    }

    void CompletePillowTask()
{
    currentState = BedTaskState.TaskComplete;

    if (VRTrainingRecorder.Instance != null)
    {
        VRTrainingRecorder.Instance.MarkBeddingCompleted();
    }
}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 0, 1, 0.5f);
        Gizmos.DrawCube(transform.position + pillowMessyCenterOffset, pillowMessySize);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + pillowMessyCenterOffset, maxDistanceFromBed);
    }
}