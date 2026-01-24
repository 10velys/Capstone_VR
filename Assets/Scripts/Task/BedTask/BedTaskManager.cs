using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;
using System.Collections.Generic;

// Enum tetap di luar class
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
    // Unity 6 Namespace
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
    public float maxDistanceFromBed = 3.0f; // Jarak maksimal bantal boleh berada dari kasur

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] allPillows;
    private bool[] pillowIsPlaced;

    void Start()
    {
        allPillows = new UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] { pillow1, pillow2, pillow3, pillow4 };

        if (allPillows.Length != pillowTargetZones.Length) Debug.LogError("Setup Error: Jumlah bantal tidak sesuai!");
       
        StartCoroutine(SpawnPillowsSafely());
        InitializePillowTask();
        
        // Memanggil fungsi ToggleInteraction agar user tidak bisa grab sebelum waktunya
        ToggleInteraction(false);
    }

    // --- FUNGSI YANG HILANG SEBELUMNYA (DITAMBAHKAN KEMBALI) ---
    public void ToggleInteraction(bool state)
    {
        foreach (var pillow in allPillows)
        {
            if (pillow != null)
            {
                // Mengaktifkan/menonaktifkan komponen interaksi agar bisa/tidak bisa dipegang
                pillow.enabled = state; 
            }
        }
    }
    // -----------------------------------------------------------

    // --- SAFETY NET YANG LEBIH KUAT ---
    void FixedUpdate()
    {
        if (currentState != BedTaskState.TidyPillows) return;

        foreach (var pillow in allPillows)
        {
            if (pillow != null && pillow.enabled)
            {
                // Cek Jarak Absolute dari titik pusat Bed Manager
                float dist = Vector3.Distance(transform.position + pillowMessyCenterOffset, pillow.transform.position);
                
                if (dist > maxDistanceFromBed) 
                {
                    Debug.LogWarning($"Bantal {pillow.name} mental terlalu jauh ({dist}m)! Respawning...");
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

        // Respawn di posisi aman (sedikit di atas area acak)
        Vector3 safePos = transform.position + pillowMessyCenterOffset + (Vector3.up * 0.6f); 
        pillow.transform.position = safePos;
        pillow.transform.rotation = Quaternion.identity;

        StartCoroutine(GentlyDropPillow(rb));
    }

    // --- LOGIC SPAWN ANTI LEDAK ---
    IEnumerator SpawnPillowsSafely()
    {
        // 1. Matikan dulu semua bantal
        foreach (var pillow in allPillows)
        {
            if (pillow == null) continue;
            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true; 
                rb.detectCollisions = false; // Matikan collision detection sementara
            }
        }

        yield return new WaitForEndOfFrame();

        // 2. Tempatkan satu per satu
        foreach (var pillow in allPillows)
        {
            if (pillow == null) continue;

            Vector3 finalPos = Vector3.zero;
            bool positionFound = false;
            int attempts = 0;
            
            // Ambil ukuran box collider bantal untuk cek overlap
            BoxCollider col = pillow.GetComponent<BoxCollider>();
            Vector3 checkSize = col != null ? col.size * 0.55f : Vector3.one * 0.2f; 

            while (!positionFound && attempts < 30) // Perbanyak attempt
            {
                Vector3 candidatePos = GetRandomPositionInVirtualBox(pillowMessyCenterOffset, pillowMessySize);
                // Selalu spawn agak tinggi biar jatuh gravitasi
                candidatePos.y = transform.position.y + pillowMessyCenterOffset.y + 0.3f; 

                // PHYSICS CHECK: Apakah ada collider lain di titik ini?
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
                // Fallback: spawn vertical stacking
                finalPos = transform.position + pillowMessyCenterOffset + (Vector3.up * (0.3f + (allPillows.Length * 0.2f)));
            }

            pillow.transform.position = finalPos;
            
            // Random rotasi
            float pillowY_Rotation = Random.Range(0f, 360f);
            pillow.transform.rotation = Quaternion.Euler(0, pillowY_Rotation, 0); 
        }

        yield return new WaitForSeconds(0.1f);

        // 3. Nyalakan Fisika dengan "Parachute Mode"
        foreach (var pillow in allPillows)
        {
            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.detectCollisions = true;
                rb.isKinematic = false;
                
                // TRICK: Pasang linear damping tinggi
                rb.linearDamping = 10f; 
                rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            }
        }

        // 4. Kembalikan fisika normal setelah 2 detik
        yield return new WaitForSeconds(2.0f);
        
        foreach (var pillow in allPillows)
        {
            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearDamping = 0f; // Kembali normal
            }
        }
    }

    IEnumerator GentlyDropPillow(Rigidbody rb)
    {
        if(rb == null) yield break;
        
        rb.detectCollisions = true;
        rb.isKinematic = false;
        rb.linearDamping = 10f; // Tahan biar ga mental
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
       
        for (int i = 0; i < allPillows.Length; i++)
        {
            if (!pillowIsPlaced[i] && allPillows[i] != null)
            {
                Collider pillowCollider = allPillows[i].GetComponent<Collider>();
                Collider zoneCollider = pillowTargetZones[i];

                bool isOverlapping = zoneCollider.bounds.Intersects(pillowCollider.bounds);
                float centerDistance = Vector3.Distance(pillowCollider.bounds.center, zoneCollider.bounds.center);

                if (isOverlapping && centerDistance <= placementPrecision)
                {
                    allPillows[i].transform.position = zoneCollider.transform.position;
                    allPillows[i].transform.rotation = zoneCollider.transform.rotation;
                   
                    Rigidbody rb = allPillows[i].GetComponent<Rigidbody>();
                    if(rb)
                    {
                        rb.isKinematic = true;
                        rb.linearVelocity = Vector3.zero;
                        rb.angularVelocity = Vector3.zero;
                    }

                    pillowIsPlaced[i] = true;
                    LockPillow(allPillows[i]);

                    if (hintController != null) hintController.OnPillowPlacedSuccess(i);
                }
            }
        }

        int successCount = 0;
        foreach(bool placed in pillowIsPlaced) if(placed) successCount++;
       
        if (successCount == allPillows.Length)
        {
            CompletePillowTask();
            if(globalManager != null) globalManager.OnBedFinished();
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
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 0, 1, 0.5f);
        Gizmos.DrawCube(transform.position + pillowMessyCenterOffset, pillowMessySize);
        
        // Visualisasi radius safety
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + pillowMessyCenterOffset, maxDistanceFromBed);
    }
}