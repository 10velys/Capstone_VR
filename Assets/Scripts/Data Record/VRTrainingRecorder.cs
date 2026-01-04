using UnityEngine;
using System.IO;
using System.Text;

public class VRTrainingRecorder : MonoBehaviour
{
    public static VRTrainingRecorder Instance;

    [Header("Sensor References")]
    public Transform headCamera;
    public Transform rightController;

    [Header("Settings")]
    public float recordFrequency = 0.04f; // ~25 FPS
    public float hesitationThreshold = 0.1f; // Speed < 0.1 m/s dianggap ragu

    // --- SESSION STATE ---
    private int sessionID;
    private bool isRecording = false;
    private float startTime;
    private float nextRecordTime = 0f;

    // --- PHYSICS VARS ---
    private Vector3 lastHandPos;
    private Vector3 lastHandVel;
    private Vector3 lastHandAcc;
    private float currentVelInst;
    private float currentJerkInst;

    // --- AGGREGATION VARS (Untuk Data Summary) ---
    private float sumVelocity = 0f;
    private float maxJerkSession = 0f;
    private float hesitationTimeTotal = 0f;
    private int dataCount = 0; // Jumlah baris data terekam

    // --- YOLO INPUT ---
    private int detectedClass = -1;
    private float detectedConf = 0f;
    
    // --- EVENT LOG ---
    private string pendingEvent = "";

    // --- BUFFER (Raw Data) ---
    private StringBuilder rawDataBuffer = new StringBuilder();

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        sessionID = PlayerPrefs.GetInt("SessionCounter", 1);
    }

    public void StartRecording()
    {
        // Update Session ID
        sessionID = PlayerPrefs.GetInt("SessionCounter", 1);
        PlayerPrefs.SetInt("SessionCounter", sessionID + 1);
        PlayerPrefs.Save();

        // Reset All State
        isRecording = true;
        startTime = Time.time;
        nextRecordTime = startTime;
        
        // Reset Aggregators
        sumVelocity = 0f;
        maxJerkSession = 0f;
        hesitationTimeTotal = 0f;
        dataCount = 0;

        // Reset Buffer Raw
        rawDataBuffer.Clear();
        // Header Raw Data (Sesuai XLSX)
        rawDataBuffer.AppendLine("timestamp,frame_count,hand_velocity_inst,hand_jerk_inst,head_pitch,detected_object_class,detected_confidence,task_event");

        // Init Physics
        if (rightController != null)
        {
            lastHandPos = rightController.position;
            lastHandVel = Vector3.zero;
            lastHandAcc = Vector3.zero;
        }

        LogEvent("Task_Start");
        Debug.Log($"[RECORDER] Session {sessionID} Started.");
    }

    public void StopAndSave(bool isSuccess)
    {
        if (!isRecording) return;
        isRecording = false;

        LogEvent(isSuccess ? "Task_Success" : "Task_Fail");
        RecordRawSnapshot(); // Catat frame terakhir

        // 1. SIMPAN RAW DATA (File per Sesi agar aman)
        string rawFileName = $"RawData_Session_{sessionID}.csv";
        string rawPath = Path.Combine(Application.persistentDataPath, rawFileName);
        File.WriteAllText(rawPath, rawDataBuffer.ToString());

        // 2. HITUNG & SIMPAN SUMMARY DATA (Accumulated)
        SaveSummaryData(isSuccess);

        Debug.Log($"[SAVED] Raw: {rawFileName} | Summary Updated.");
    }

    void Update()
    {
        if (!isRecording || rightController == null) return;

        // A. Kalkulasi Fisika Real-time
        float dt = Time.deltaTime;
        if (dt > 0)
        {
            Vector3 currentPos = rightController.position;
            Vector3 currentVel = (currentPos - lastHandPos) / dt;
            Vector3 currentAcc = (currentVel - lastHandVel) / dt;
            Vector3 currentJerk = (currentAcc - lastHandAcc) / dt;

            currentVelInst = currentVel.magnitude;
            currentJerkInst = currentJerk.magnitude;

            lastHandPos = currentPos;
            lastHandVel = currentVel;
            lastHandAcc = currentAcc;

            // B. Update Aggregators (Untuk Summary nanti)
            // Kita hitung hesitation di tiap frame update biar akurat
            if (currentVelInst < hesitationThreshold)
            {
                hesitationTimeTotal += dt;
            }
            
            // Max Jerk check
            if (currentJerkInst > maxJerkSession)
            {
                maxJerkSession = currentJerkInst;
            }
        }

        // C. Record Raw Data (Sesuai Frequency)
        if (Time.time >= nextRecordTime)
        {
            RecordRawSnapshot();
            
            // Tambahkan ke Sum untuk rata-rata nanti
            sumVelocity += currentVelInst;
            dataCount++; // Total sampel
            
            nextRecordTime = Time.time + recordFrequency;
        }
    }

    void RecordRawSnapshot()
    {
        float timeStamp = Time.time - startTime;
        int frame = Time.frameCount;
        
        float headPitch = 0f;
        if (headCamera != null)
        {
            headPitch = headCamera.eulerAngles.x;
            if (headPitch > 180) headPitch -= 360;
        }

        string eventLog = pendingEvent;
        pendingEvent = "";

        // Format CSV Raw (Data Mentah)
        string line = string.Format("{0:F3},{1},{2:F4},{3:F4},{4:F2},{5},{6:F2},{7}",
            timeStamp, frame, currentVelInst, currentJerkInst, headPitch, 
            detectedClass, detectedConf, eventLog);

        rawDataBuffer.AppendLine(line);
    }

    void SaveSummaryData(bool isSuccess)
    {
        string summaryPath = Path.Combine(Application.persistentDataPath, "Session_Summary.csv");
        bool fileExists = File.Exists(summaryPath);

        using (StreamWriter writer = new StreamWriter(summaryPath, true))
        {
            // Buat Header jika file baru (Sesuai Gambar Konsep ML Anda)
            if (!fileExists)
            {
                writer.WriteLine("session_id,avg_hand_velocity,max_hand_jerk,hesitation_time,total_duration,completion_rate,label");
            }

            // --- HITUNG RATA-RATA ---
            float avgVel = (dataCount > 0) ? (sumVelocity / dataCount) : 0f;
            float duration = Time.time - startTime;
            float completionRate = isSuccess ? 1.0f : 0.0f; // Sederhana dulu
            int label = (isSuccess && duration < 180) ? 1 : 0; // Rule-based Label

            // Tulis Baris Summary
            string line = string.Format("{0},{1:F4},{2:F4},{3:F2},{4:F2},{5:F2},{6}",
                sessionID, avgVel, maxJerkSession, hesitationTimeTotal, duration, completionRate, label);

            writer.WriteLine(line);
        }
    }

    // --- YOLO BRIDGE ---
    public void SetDetectedObject(int classId, float confidence)
    {
        detectedClass = classId;
        detectedConf = confidence;
    }

    public void LogEvent(string ev) => pendingEvent = ev;
}