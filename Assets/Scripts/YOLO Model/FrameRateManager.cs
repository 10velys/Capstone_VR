using UnityEngine;
using System.Collections;

public class FrameRateManager : MonoBehaviour
{
    // Opsi: 72, 80, 90, 120 (Untuk Quest 3S disarankan 72 atau 90)
    // 72Hz = Paling stabil untuk game berat / AI berat
    // 90Hz = Lebih smooth jika performa game ringan
    [Range(72, 120)]
    public int targetFrameRate = 72;

    [Header("Optimization")]
    public bool fixPhysicsRate = true;
    public bool enableFFR = true;

    void Start()
    {
        SetupVRFrameRate();
    }

    void SetupVRFrameRate()
    {
        // 1. Matikan VSync Unity (Biar OVR yang handle)
        QualitySettings.vSyncCount = 0;

        // 2. Set Target FPS di level Unity
        Application.targetFrameRate = targetFrameRate;

        // 3. PERBAIKAN PHYSICS JITTER (KUNCI UTAMA)
        // Mengubah update fisika agar sinkron dengan FPS (misal: 1/72 detik)
        if (fixPhysicsRate)
        {
            Time.fixedDeltaTime = 1.0f / (float)targetFrameRate;
            Debug.Log($"[VR Setup] FixedDeltaTime set to: {Time.fixedDeltaTime} for {targetFrameRate} FPS");
        }

        // 4. PEMAKSAAN HARDWARE VIA OVR (Meta Quest SDK)
        // Script ini memastikan layar Quest benar-benar pindah mode ke Hz yang diinginkan
        StartCoroutine(EnforceOVRSettings());
    }

    IEnumerator EnforceOVRSettings()
    {
        // Tunggu sebentar sampai OVR Manager siap
        yield return new WaitForSeconds(1.0f);

        // Cek apakah OVRManager ada (Pastikan Oculus XR Plugin terinstall)
        if (OVRManager.display != null)
        {
            // Paksa Refresh Rate
            OVRManager.display.displayFrequency = (float)targetFrameRate;
            Debug.Log($"[VR Setup] OVR Display Frequency requested: {targetFrameRate}");
        }

        // 5. Fixed Foveated Rendering (FFR)
        // Mengurangi resolusi di pinggir lensa (tak terlihat mata) untuk performa GPU
        if (enableFFR)
        {
            OVRManager.fixedFoveatedRenderingLevel = OVRManager.FixedFoveatedRenderingLevel.High;
            OVRManager.useDynamicFixedFoveatedRendering = true; // Otomatis naik turun sesuai beban
        }

        // Loop penjaga (Watchdog) - Cek setiap 3 detik
        var wait = new WaitForSeconds(3.0f);
        while (true)
        {
            // Jika FPS Unity berubah, kembalikan
            if (Application.targetFrameRate != targetFrameRate)
                Application.targetFrameRate = targetFrameRate;

            // Jika OVR berubah (misal habis buka menu home), kembalikan
            if (OVRManager.display != null && 
                Mathf.Abs(OVRManager.display.displayFrequency - targetFrameRate) > 0.1f)
            {
                OVRManager.display.displayFrequency = (float)targetFrameRate;
            }

            yield return wait;
        }
    }
}