using UnityEngine;
using System.Collections.Generic;
// Namespace untuk Unity 6 / XR Interaction Toolkit 3.x
using UnityEngine.XR.Interaction.Toolkit.Interactables; 

public class TrashManager : MonoBehaviour
{
    [Header("Global Manager Reference")]
    public GlobalRoomManager globalManager;

    [Header("Daftar Sampah")]
    public Transform[] trashPapers; 

    [Header("Area Random Spawn")]
    public Vector2 randomAreaSize = new Vector2(2f, 2f); 

    // Internal Variable
    private int collectedCount = 0;
    private int totalTrash = 0;

    // PERBAIKAN: Menyimpan Interactable Cache agar tidak GetComponent berulang-ulang
    private List<XRGrabInteractable> trashInteractables = new List<XRGrabInteractable>();

    void Awake()
    {
        // PERBAIKAN: Kita cache semua component Grab di awal (Awake)
        // Ini lebih aman daripada mencarinya saat runtime (ToggleInteraction)
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
        
        // PERBAIKAN: Hapus/Comment bagian "AUTO-FIX" yang lama.
        // Alasan: Kode 'grab.colliders.Clear()' berisiko merusak setup yang sudah benar di Inspector.
        // XR Grab Interactable di Unity 6 sudah sangat pintar mendeteksi collider secara otomatis.
        // Jika di Inspector (gambar image_182be6.jpg) sudah ada Mesh Collider, biarkan saja.
        
        foreach (Transform t in trashPapers)
        {
            if (t == null) continue;
            
            // Pastikan Rigidbody siap agar bisa jatuh (Gravity ON)
            Rigidbody rb = t.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.isKinematic = false; // Fisika nyala agar jatuh ke lantai
                rb.useGravity = true;
            }
        }

        // 2. Sebar posisi sampah
        ScatterTrash();
    }

    void ScatterTrash()
    {
        foreach (Transform paper in trashPapers)
        {
            if (paper == null) continue;

            float randomX = Random.Range(-randomAreaSize.x / 2, randomAreaSize.x / 2);
            float randomZ = Random.Range(-randomAreaSize.y / 2, randomAreaSize.y / 2);

            // Posisi Y +0.5f agar jatuh natural
            Vector3 newPos = new Vector3(
                transform.position.x + randomX,
                transform.position.y + 0.5f, 
                transform.position.z + randomZ
            );

            paper.position = newPos;
            paper.rotation = Random.rotation;
        }
    }

    // --- FUNGSI INTERAKSI "PERBAIKAN" ---
    public void ToggleInteraction(bool state)
    {
        // Kita loop list yang sudah di-cache di Awake
        foreach (var interactable in trashInteractables)
        {
            if (interactable == null) continue;

            // PERBAIKAN UTAMA:
            // Jangan mainkan 'interactionLayers'. Cukup matikan/nyalakan component script-nya.
            // Jika script disabled = Tidak bisa di-grab, tidak muncul hover, tapi fisik (Rigidbody) tetap ada.
            
            interactable.enabled = state; 
            
            // Opsi Tambahan: Mengatur Fisika saat dimatikan/dinyalakan
            // Jika 'state' false (Task belum aktif), kita biarkan physics tetap jalan (isKinematic = false)
            // supaya sampahnya terlihat "berantakan" di lantai (bisa ditendang kaki), tapi tidak bisa diambil tangan.
            Rigidbody rb = interactable.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Kita pastikan selalu false agar gravitasi bekerja dan terlihat natural
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
            if (globalManager != null) 
            {
                globalManager.OnTrashFinished();
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(randomAreaSize.x, 0.1f, randomAreaSize.y));
    }
}