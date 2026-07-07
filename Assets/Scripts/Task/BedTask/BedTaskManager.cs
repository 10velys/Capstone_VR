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

    [Header("Randomization Floor Settings")]
    public Vector3 floorCenterOffset = new Vector3(0f, 0f, 0.5f); // Baru: Untuk memajukan/menggeser pusat acak bantal
    public float sideOffset = 1.5f; 
    public float floorSpawnHeight = 0.05f;
    public Vector3 sideAreaSize = new Vector3(0.6f, 0.1f, 1.2f);
    [Range(0, 90)]
    public float maxMessyTilt = 20f;
   
    [Header("Task Settings")]
    public float placementPrecision = 0.5f;
    
    [Header("Safety Settings")]
    public float maxDistanceFromBed = 5.0f;

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
                float dist = Vector3.Distance(transform.position, pillow.transform.position);
                
                if (dist > maxDistanceFromBed) 
                {
                    RespawnSinglePillow(pillow);
                }
            }
        }
    }

    Vector3 GetHorizontalRightDirection()
    {
        if (pillowTargetZones != null && pillowTargetZones.Length > 0 && pillowTargetZones[0] != null)
        {
            Vector3 localRight = pillowTargetZones[0].transform.right;
            localRight.y = 0f; 
            return localRight.normalized;
        }
        return Vector3.right;
    }

    Vector3 GetHorizontalForwardDirection()
    {
        if (pillowTargetZones != null && pillowTargetZones.Length > 0 && pillowTargetZones[0] != null)
        {
            Vector3 localForward = pillowTargetZones[0].transform.forward;
            localForward.y = 0f; 
            return localForward.normalized;
        }
        return Vector3.forward;
    }

    Vector3 GetFinalCenterPosition()
    {
        Vector3 basePosition = (pillowTargetZones != null && pillowTargetZones.Length > 0 && pillowTargetZones[0] != null) 
            ? pillowTargetZones[0].transform.position 
            : transform.position;

        Vector3 bedRight = GetHorizontalRightDirection();
        Vector3 bedForward = GetHorizontalForwardDirection();

        // Menghitung posisi tengah baru berdasarkan penyesuaian offset di Inspector
        return basePosition + (bedRight * floorCenterOffset.x) + (Vector3.up * floorCenterOffset.y) + (bedForward * floorCenterOffset.z);
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

        Vector3 centerPos = GetFinalCenterPosition();
        Vector3 bedRight = GetHorizontalRightDirection();

        int sideRandom = Random.Range(0, 2);
        float currentSideOffset = (sideRandom == 0) ? -sideOffset : sideOffset;
        
        Vector3 sideCenter = centerPos + bedRight * currentSideOffset;
        
        Vector3 safePos = GetRandomPositionInBox(sideCenter, sideAreaSize);
        safePos.y = floorSpawnHeight + 0.3f;

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

        Vector3 centerPos = GetFinalCenterPosition();
        Vector3 bedRight = GetHorizontalRightDirection();

        for (int i = 0; i < allPillows.Length; i++)
        {
            var pillow = allPillows[i];
            if (pillow == null) continue;

            float currentSideOffset = (i % 2 == 0) ? -sideOffset : sideOffset;
            Vector3 sideCenter = centerPos + bedRight * currentSideOffset;

            Vector3 finalPos = Vector3.zero;
            bool positionFound = false;
            int attempts = 0;
            
            BoxCollider col = pillow.GetComponent<BoxCollider>();
            Vector3 checkSize = col != null ? col.size * 0.55f : Vector3.one * 0.2f; 

            while (!positionFound && attempts < 30)
            {
                Vector3 candidatePos = GetRandomPositionInBox(sideCenter, sideAreaSize);
                candidatePos.y = floorSpawnHeight + 0.2f; 

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
                finalPos = sideCenter;
                finalPos.y = floorSpawnHeight + 0.2f + (i * 0.1f);
            }

            pillow.transform.position = finalPos;
            float pillowY_Rotation = Random.Range(0f, 360f);
            float randomX_Tilt = Random.Range(-maxMessyTilt, maxMessyTilt);
            float randomZ_Tilt = Random.Range(-maxMessyTilt, maxMessyTilt);
            pillow.transform.rotation = Quaternion.Euler(randomX_Tilt, pillowY_Rotation, randomZ_Tilt); 
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

    Vector3 GetRandomPositionInBox(Vector3 center, Vector3 size)
    {
        Vector3 min = center - size / 2;
        Vector3 max = center + size / 2;
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
                pillow.useDynamicAttach = true;
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
        float distance = Vector3.Distance(pillow.transform.position, zone.transform.position);
        return isOverlapping && distance <= placementPrecision;
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
        
        for (int i = 0; i < pillowIsPlaced.Length; i++)
        {
            if (pillowIsPlaced[i])
            {
                successCount++;
            }
        }

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
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        
        Vector3 centerPos = GetFinalCenterPosition();
        Vector3 bedRight = GetHorizontalRightDirection();

        Vector3 leftCenter = centerPos - bedRight * sideOffset;
        leftCenter.y = floorSpawnHeight;
        Gizmos.DrawCube(leftCenter, sideAreaSize);

        Vector3 rightCenter = centerPos + bedRight * sideOffset;
        rightCenter.y = floorSpawnHeight;
        Gizmos.DrawCube(rightCenter, sideAreaSize);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(centerPos, maxDistanceFromBed);
    }
}