using UnityEngine;
using System.Collections;

public class FrameRateManager : MonoBehaviour
{
    // Targetkan 72Hz untuk kestabilan AI
    private int targetFrameRate = 72;

    void Start()
    {
        // 1. Matikan VSync bawaan Unity (PENTING: agar tidak konflik dengan Quest Compositor)
        QualitySettings.vSyncCount = 0;

        // 2. Set Target FPS
        // Pada Meta Quest (Android), perintah ini otomatis meminta headset pindah ke 72Hz/90Hz/120Hz
        Application.targetFrameRate = targetFrameRate;
        
        // Opsional: Cek ulang setiap beberapa detik untuk memastikan setting tidak berubah
        StartCoroutine(EnforceFrameRate());
    }

    IEnumerator EnforceFrameRate()
    {
        WaitForSeconds wait = new WaitForSeconds(5.0f);
        while (true)
        {
            if (Application.targetFrameRate != targetFrameRate)
            {
                Application.targetFrameRate = targetFrameRate;
            }
            yield return wait;
        }
    }
}