using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
// using UnityEngine.XR.Interaction.Toolkit.Interactables; // Uncomment baris ini jika pakai Unity 6

// --- PENTING: Enum ini harus ada di luar class ---
public enum BedTaskState
{
    TidyPillows,
    TaskComplete
}

public class BedTaskManager : MonoBehaviour
{
    [Header("Global Manager")]
    public GlobalRoomManager globalManager; // <--- REFERENSI KE GLOBAL

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
    // PENTING: Zone ini harus ditaruh di posisi RAPIH (posisi final)
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
        RandomizePositions();
        InitializePillowTask();

        // PENTING: Matikan interaksi di awal (karena harus menunggu Task Sampah selesai)
        // GlobalManager yang akan menyalakannya nanti.
        ToggleInteraction(false);
    }

    // Fungsi untuk menyalakan/mematikan interaksi (Dipanggil oleh GlobalManager)
    public void ToggleInteraction(bool state)
    {
        foreach (var pillow in allPillows)
        {
            if (pillow != null)
            {
                pillow.enabled = state; // Matikan/Nyalakan script grab
            }
        }
    }
   
    void RandomizePositions()
    {
        foreach (var pillow in allPillows)
        {
            if (pillow == null) continue;

            // Pindahkan bantal ke posisi berantakan
            pillow.transform.position = GetRandomPositionInVirtualBox(pillowMessyCenterOffset, pillowMessySize);
           
            // Acak rotasi
            float pillowY_Rotation = Random.Range(0f, 360f);
            float pillowX_Tilt = Random.Range(-maxMessyTilt, maxMessyTilt);
            float pillowZ_Tilt = Random.Range(-maxMessyTilt, maxMessyTilt);
            pillow.transform.rotation = Quaternion.Euler(pillowX_Tilt, pillowY_Rotation, pillowZ_Tilt);
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
                // Listener tetap dipasang, tapi tidak akan jalan kalau component disabled
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

                // Cek Jarak & Overlap
                bool isOverlapping = zoneCollider.bounds.Intersects(pillowCollider.bounds);
                float centerDistance = Vector3.Distance(pillowCollider.bounds.center, zoneCollider.bounds.center);

                // Jika sudah cukup dekat
                if (isOverlapping && centerDistance <= placementPrecision)
                {
                    Debug.Log("Bantal " + (i + 1) + " Snapped!");

                    // --- SNAP LOGIC ---
                    allPillows[i].transform.position = zoneCollider.transform.position;
                    allPillows[i].transform.rotation = zoneCollider.transform.rotation;
                   
                    // Matikan Physics biar diem
                    Rigidbody rb = allPillows[i].GetComponent<Rigidbody>();
                    if(rb)
                    {
                        rb.isKinematic = true;
                        rb.linearVelocity = Vector3.zero;
                        rb.angularVelocity = Vector3.zero;
                    }

                    // Kunci status
                    pillowIsPlaced[i] = true;
                    LockPillow(allPillows[i]);

                    // --- UPDATE HINT ---
                    if (hintController != null)
                    {
                        hintController.OnPillowPlacedSuccess(i);
                    }
                }
            }
        }

        // Cek Win Condition (Apakah semua bantal sudah terpasang?)
        int successCount = 0;
        foreach(bool placed in pillowIsPlaced) if(placed) successCount++;
       
        if (successCount == allPillows.Length)
        {
            CompletePillowTask();

            // TAMBAHAN: Lapor ke Global Manager agar lanjut ke Task Handuk
            if(globalManager != null) 
            {
                globalManager.OnBedFinished();
            }
        }
    }

    void LockPillow(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable pillow)
    {
        // Matikan kemampuan grab agar bantal terkunci
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