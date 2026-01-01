using UnityEngine;
using Unity.XR.CoreUtils; // Kita perlu ini untuk mengakses XROrigin

// Pastikan komponen ini ada di objek yang sama
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(XROrigin))]
public class RoomScaleCollisionFix : MonoBehaviour
{
    // Seret (drag) Main Camera Anda ke slot ini di Inspector
    public Transform mainCameraTransform;

    private XROrigin xrOrigin;
    private CharacterController characterController;

    // Simpan nilai Y-Center asli dari Inspector
    private float originalCenterY;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        xrOrigin = GetComponent<XROrigin>();
        
        // Simpan nilai Y-Center awal yang Anda atur (0.68072)
        originalCenterY = characterController.center.y;

        // Coba temukan kamera secara otomatis jika pengguna lupa menyeretnya
        if (mainCameraTransform == null)
        {
            if (Camera.main != null)
            {
                mainCameraTransform = Camera.main.transform;
            }
            else
            {
                Debug.LogError("RoomScaleCollisionFix: 'Main Camera Transform' belum di-set! Harap seret 'Main Camera' Anda ke slot script di Inspector.", this);
            }
        }
    }

    // Gunakan LateUpdate agar script ini berjalan
    // SETELAH semua kalkulasi tracking VR dan gerakan joystick selesai
    void LateUpdate()
    {
        if (mainCameraTransform == null || characterController == null || xrOrigin == null)
            return;

        // 1. Dapatkan posisi kepala (kamera) di "Tracking Space"
        // (yaitu, posisi HMD relatif terhadap lantai di dunia nyata)
        // Ini adalah properti yang benar untuk digunakan
        Vector3 headPositionInOriginSpace = xrOrigin.CameraInOriginSpacePos;

        // 2. Buat vector 'center' baru untuk Character Controller
        Vector3 newCenter = characterController.center;

        // 3. Atur 'center' X dan Z agar sama dengan posisi XZ kepala
        newCenter.x = headPositionInOriginSpace.x;
        newCenter.z = headPositionInOriginSpace.z;
        
        // 4. JANGAN UBAH Y. Gunakan nilai Y asli dari Inspector
        // (Ini penting agar kapsul collider Anda tidak melayang)
        newCenter.y = originalCenterY;

        // 5. Terapkan 'center' baru ke Character Controller
        characterController.center = newCenter;
    }
}