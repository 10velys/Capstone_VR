using UnityEngine;

public class FollowHead : MonoBehaviour
{
    [Header("Settings")]
    public Transform headCamera;    // Masukkan Main Camera di sini
    public float distance = 1.0f;   // Jarak menu dari mata (meter)
    public float smoothSpeed = 5.0f; // Semakin kecil = makin lambat/mulus. Semakin besar = makin cepat nempel.

    void LateUpdate() // LateUpdate bagus untuk UI agar tidak bergetar mengikuti kamera
    {
        if (headCamera == null) return;

        // 1. Tentukan Posisi Target (Tepat di depan muka user sejauh 'distance')
        Vector3 targetPosition = headCamera.position + (headCamera.forward * distance);

        // 2. Gerakkan Canvas pelan-pelan ke posisi target (Interpolasi/Lerp)
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);

        // 3. Putar Canvas agar selalu menghadap arah yang sama dengan muka user (biar tegak lurus)
        transform.rotation = Quaternion.Slerp(transform.rotation, headCamera.rotation, Time.deltaTime * smoothSpeed);
    }
}