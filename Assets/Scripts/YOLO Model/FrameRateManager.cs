using UnityEngine;
using System.Collections;

public class FrameRateManager : MonoBehaviour
{
    [Header("Settings")]
    [Range(72, 120)] public int targetFrameRate = 72;
    public bool fixPhysicsRate = true;
    
    [Header("Performance Lock")]
    public bool forceHighPerformance = true; // Wajib TRUE untuk masalah "Second Run"
    public bool useDynamicFFR = false; // Set FALSE agar stabil sejak detik pertama

    void Awake()
    {
        // Eksekusi paling awal untuk memastikan setting diterapkan sebelum game berat mulai
        ApplySettings();
    }

    void Start()
    {
        // Penjaga untuk memastikan setting tidak berubah sendiri
        StartCoroutine(WatchdogRoutine());
    }

    // PENTING: Menangani saat User melepas headset atau Quit lalu Buka lagi
    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            ApplySettings();
        }
    }

    void ApplySettings()
    {
        // 1. Matikan VSync Unity
        QualitySettings.vSyncCount = 0;

        // 2. Set Target FPS di Engine Unity
        Application.targetFrameRate = targetFrameRate;

        // 3. FORCE PHYSICS (Anti-Jitter / Anti-Getar)
        if (fixPhysicsRate)
        {
            float targetFixedDt = 1.0f / (float)targetFrameRate;
            Time.fixedDeltaTime = targetFixedDt;
        }

        // 4. SETTING KHUSUS META QUEST (OVR)
        if (OVRManager.display != null)
        {
            // A. Paksa Layar ke Hz yang diinginkan (Dari Script Atas - Lebih Kuat)
            OVRManager.display.displayFrequency = (float)targetFrameRate;

            // B. Fixed Foveated Rendering (FFR)
            OVRManager.fixedFoveatedRenderingLevel = OVRManager.FixedFoveatedRenderingLevel.High;
            OVRManager.useDynamicFixedFoveatedRendering = useDynamicFFR; // False = Lebih stabil

            // C. PERFORMANCE LOCK (Dari Script Bawah - Anti Throttling)
            if (forceHighPerformance)
            {
                OVRManager.suggestedCpuPerfLevel = OVRManager.ProcessorPerformanceLevel.SustainedHigh;
                OVRManager.suggestedGpuPerfLevel = OVRManager.ProcessorPerformanceLevel.SustainedHigh;
            }
        }
        
        Debug.Log($"[VR Setup] Applied: {targetFrameRate}Hz | FixedDelta: {Time.fixedDeltaTime} | Perf: High");
    }

    IEnumerator WatchdogRoutine()
    {
        var wait = new WaitForSeconds(2.0f);
        while (true)
        {
            // Cek 1: Apakah FPS Unity berubah?
            if (Application.targetFrameRate != targetFrameRate)
                Application.targetFrameRate = targetFrameRate;

            // Cek 2: Apakah Physics berubah?
            if (fixPhysicsRate && Mathf.Abs(Time.fixedDeltaTime - (1.0f / targetFrameRate)) > 0.0001f)
                Time.fixedDeltaTime = 1.0f / (float)targetFrameRate;

            // Cek 3: Apakah Hardware Quest berubah Hz-nya? (Penting!)
            if (OVRManager.display != null)
            {
                if (Mathf.Abs(OVRManager.display.displayFrequency - targetFrameRate) > 0.1f)
                {
                    OVRManager.display.displayFrequency = (float)targetFrameRate;
                }
            }

            yield return wait;
        }
    }
}