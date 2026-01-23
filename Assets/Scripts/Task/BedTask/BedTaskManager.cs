using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
// Sesuaikan namespace ini jika error. Di Unity 6 biasanya perlu:
// using UnityEngine.XR.Interaction.Toolkit.Interactables; 

// --- PENTING: Enum ini harus ada di luar class ---
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
    // Menggunakan full namespace agar aman
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

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] allPillows;
    private bool[] pillowIsPlaced;

    void Start()
    {
        // Inisialisasi Array Bantal
        allPillows = new UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] { pillow1, pillow2, pillow3, pillow4 };

        if (allPillows.Length != pillowTargetZones.Length)
        {
            Debug.LogError("Setup Error: Jumlah bantal dan zona target tidak sama!");
        }
       
        // Acak posisi bantal saat mulai
        StartCoroutine(SpawnPillowsSafely());
        InitializePillowTask();

        // Matikan interaksi di awal (menunggu Task Sampah selesai)
        ToggleInteraction(false);
    }

    // --- FUNGSI SAFETY NET BARU (PENTING) ---
    void FixedUpdate()
    {
        // Hanya cek jika sedang dalam fase merapikan bantal
        if (currentState != BedTaskState.TidyPillows) return;

        foreach (var pillow in allPillows)
        {
            if (pillow != null && pillow.enabled) // Cek hanya jika bantal aktif
            {
                // Jika posisi Y bantal di bawah -2 (jatuh ke lantai/void)
                // Sesuaikan angka -2f ini dengan ketinggian lantai scene Anda
                if (pillow.transform.position.y < -2f)
                {
                    Debug.LogWarning($"Bantal {pillow.name} jatuh ke void! Respawning...");
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
            rb.linearVelocity = Vector3.zero; // Unity 6 pakai linearVelocity
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true; // Matikan fisika sejenak
        }

        // Reset posisi ke atas kasur (posisi aman)
        // Menggunakan posisi transform manager + offset + sedikit ke atas
        Vector3 safePos = transform.position + pillowMessyCenterOffset + (Vector3.up * 0.5f);
        pillow.transform.position = safePos;
        pillow.transform.rotation = Quaternion.identity;

        if(rb)
        {
            rb.isKinematic = false; // Nyalakan fisika lagi
        }
    }
    // ----------------------------------------

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
   
    // --- LOGIC SPAWN YANG DIPERBAIKI ---
    System.Collections.IEnumerator SpawnPillowsSafely()
    {
        System.Collections.Generic.List<Vector3> usedPositions = new System.Collections.Generic.List<Vector3>();
        float minSafeDistance = 0.5f; // Jarak aman antar bantal

        foreach (var pillow in allPillows)
        {
            if (pillow == null) continue;

            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            
            // 1. Matikan total fisika agar tidak meledak saat dipindah
            if (rb != null)
            {
                rb.isKinematic = true; 
                rb.detectCollisions = false; 
                // Ganti mode collision biar tidak tembus tembok
                rb.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            }

            // 2. Cari posisi aman
            Vector3 finalPos = Vector3.zero;
            bool positionFound = false;
            int attempts = 0;

            while (!positionFound && attempts < 15)
            {
                Vector3 candidatePos = GetRandomPositionInVirtualBox(pillowMessyCenterOffset, pillowMessySize);
                
                // [FIX] Tambahkan 0.4f ke atas (Y) agar bantal spawn DI UDARA, bukan di dalam kasur
                candidatePos.y = transform.position.y + pillowMessyCenterOffset.y + 0.4f; 

                // Cek jarak dengan bantal lain
                bool overlap = false;
                foreach (Vector3 existingPos in usedPositions)
                {
                    if (Vector3.Distance(candidatePos, existingPos) < minSafeDistance)
                    {
                        overlap = true;
                        break;
                    }
                }

                if (!overlap)
                {
                    finalPos = candidatePos;
                    positionFound = true;
                }
                attempts++;
            }

            // Fallback jika tidak nemu posisi
            if (!positionFound) 
            {
                finalPos = transform.position + pillowMessyCenterOffset + (Vector3.up * 0.5f);
            }

            usedPositions.Add(finalPos);
            pillow.transform.position = finalPos;

            // 3. Acak Rotasi (Safe Tilt)
            float pillowY_Rotation = Random.Range(0f, 360f);
            float safeTilt = 5f; // Tilt kecil saja biar stabil
            pillow.transform.rotation = Quaternion.Euler(Random.Range(-safeTilt, safeTilt), pillowY_Rotation, Random.Range(-safeTilt, safeTilt));
        }

        // 4. [FIX] Tunggu 0.2 detik (bukan 1 frame) agar posisi benar-benar set
        yield return new WaitForSeconds(0.2f);

        // 5. Nyalakan fisika kembali
        foreach (var pillow in allPillows)
        {
            Rigidbody rb = pillow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.detectCollisions = true;
                rb.isKinematic = false; // Biarkan jatuh ke kasur
            }
        }
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
                    Debug.Log("Bantal " + (i + 1) + " Snapped!");

                    // --- SNAP LOGIC ---
                    allPillows[i].transform.position = zoneCollider.transform.position;
                    allPillows[i].transform.rotation = zoneCollider.transform.rotation;
                   
                    Rigidbody rb = allPillows[i].GetComponent<Rigidbody>();
                    if(rb)
                    {
                        rb.isKinematic = true;
                        rb.linearVelocity = Vector3.zero; // Unity 6
                        rb.angularVelocity = Vector3.zero;
                    }

                    pillowIsPlaced[i] = true;
                    LockPillow(allPillows[i]);

                    if (hintController != null)
                    {
                        hintController.OnPillowPlacedSuccess(i);
                    }
                }
            }
        }

        int successCount = 0;
        foreach(bool placed in pillowIsPlaced) if(placed) successCount++;
       
        if (successCount == allPillows.Length)
        {
            CompletePillowTask();
            if(globalManager != null) 
            {
                globalManager.OnBedFinished();
            }
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
        Debug.Log("SEMUA BANTAL RAPI!");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 0, 1, 0.5f);
        Gizmos.DrawCube(transform.position + pillowMessyCenterOffset, pillowMessySize);
    }
}