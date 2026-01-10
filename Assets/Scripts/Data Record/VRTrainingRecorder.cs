using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Penting untuk perhitungan Rata-rata & Sum

public class VRTrainingRecorder : MonoBehaviour
{
    public static VRTrainingRecorder Instance;

    [Header("Sensor References")]
    public Transform headCamera;
    public Transform rightController;

    [Header("Session Settings")]
    public int current_level = 1; // Bisa diubah via GameManager saat ganti level
    public float hesitationThreshold = 0.05f; // Velocity < 0.05 dianggap ragu

    // --- STATE VARIABLES ---
    private string session_id;
    private bool isRecording = false;
    private float startTime;
    private float nextRecordTime = 0f;

    // --- PHYSICS TEMP VARS (Real-time calculation) ---
    private Vector3 lastHandPos;
    private float currentVelInst; // Kecepatan saat ini (dihitung tiap frame)
    private float currentJerkInst; // Hentakan saat ini (dihitung tiap frame)
    private Vector3 lastHandVel;
    private Vector3 lastHandAcc;

    // --- YOLO INPUT (Updated by YoloDetector) ---
    private int current_detected_class = -1;
    private float current_detected_conf = 0f;

    // --- TEMPORARY RAW DATA STORAGE (IN MEMORY) ---
    // Class kecil untuk menyimpan snapshot data per detik
    private class RawDataPoint
    {
        public float hand_velocity_inst;
        public float hand_jerk_inst;
        public float head_pitch;
        public float detected_conf;
        // detected_class disimpan jika butuh logika spesifik, 
        // tapi untuk task_completion_rate kita butuh confidennya.
    }

    private List<RawDataPoint> rawDataLog = new List<RawDataPoint>();

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void StartRecording()
    {
        // 1. Setup Session ID
        int sessionCounter = PlayerPrefs.GetInt("SessionCounter", 1);
        session_id = $"USER_{System.DateTime.Now:yyyyMMdd}_{sessionCounter:D3}";
        PlayerPrefs.SetInt("SessionCounter", sessionCounter + 1);
        PlayerPrefs.Save();

        // 2. Reset State
        rawDataLog.Clear(); // Hapus memori lama
        isRecording = true;
        startTime = Time.time;
        nextRecordTime = startTime; // Rekam detik ke-0

        // 3. Reset Physics
        if (rightController != null)
        {
            lastHandPos = rightController.position;
            lastHandVel = Vector3.zero;
            lastHandAcc = Vector3.zero;
        }

        Debug.Log($"[RECORDER] Session {session_id} Started. Logging at 1 Hz.");
    }

    public void StopAndSave()
    {
        if (!isRecording) return;
        isRecording = false;

        // Proses Aggregasi Data dari Memory List -> CSV
        ProcessAndSaveAggregation();

        Debug.Log($"[RECORDER] Session Stopped. Summary Saved.");
    }

    void Update()
    {
        if (!isRecording || rightController == null) return;

        // A. HITUNG FISIKA (Setiap Frame agar akurat)
        // Kita butuh nilai instantaneous (saat ini) yang akurat untuk disnapshot nanti
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
        }

        // B. DATA LOGGING (1 Detik Sekali)
        if (Time.time >= nextRecordTime)
        {
            LogSnapshotInMemory();
            nextRecordTime = Time.time + 1.0f; // Interval fix 1 detik
        }
    }

    // Fungsi menyimpan data mentah ke RAM (List)
    void LogSnapshotInMemory()
    {
        float pitch = 0f;
        if (headCamera != null)
        {
            pitch = headCamera.eulerAngles.x;
            if (pitch > 180) pitch -= 360; // Normalisasi -180 s/d 180
        }

        RawDataPoint point = new RawDataPoint
        {
            hand_velocity_inst = currentVelInst,
            hand_jerk_inst = currentJerkInst,
            head_pitch = pitch,
            detected_conf = current_detected_conf
        };

        rawDataLog.Add(point);
    }

    // Fungsi Utama: Mengubah Raw Data -> Aggregated Data -> CSV
    void ProcessAndSaveAggregation()
    {
        if (rawDataLog.Count == 0) return;

        // --- 1. HITUNG DATA AGREGASI (Sesuai Rumus PDF) ---

        // a. avg_hand_velocity
        float avg_hand_velocity = rawDataLog.Average(x => x.hand_velocity_inst);

        // b. max_hand_jerk
        float max_hand_jerk = rawDataLog.Max(x => x.hand_jerk_inst);

        // c. hesitation_time
        // Rumus: Count(velocity < 0.05) * 1 detik (karena interval kita 1 detik)
        int hesitationCount = rawDataLog.Count(x => x.hand_velocity_inst < hesitationThreshold);
        float hesitation_time = hesitationCount * 1.0f; 

        // d. focus_consistency (StdDev of head_pitch)
        float focus_consistency = CalculateStdDev(rawDataLog.Select(x => x.head_pitch).ToList());

        // e. total_duration
        float total_duration = Time.time - startTime;

        // f. task_completion_rate (Mean of detected_conf)
        // Rata-rata confidence YOLO sepanjang sesi
        float task_completion_rate = rawDataLog.Average(x => x.detected_conf);

        // --- 2. TULIS KE CSV ---
        string filePath = Path.Combine(Application.persistentDataPath, "Session_Summary.csv");
        bool fileExists = File.Exists(filePath);

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            // Buat Header jika file baru (Sesuai nama variabel Gambar Aggregasi)
            if (!fileExists)
            {
                writer.WriteLine("session_id,current_level,avg_hand_velocity,max_hand_jerk,hesitation_time,focus_consistency,total_duration,task_completion_rate");
            }

            // Tulis Baris Data
            string line = string.Format("{0},{1},{2:F4},{3:F4},{4:F2},{5:F4},{6:F2},{7:F4}",
                session_id,
                current_level,
                avg_hand_velocity,
                max_hand_jerk,
                hesitation_time,
                focus_consistency,
                total_duration,
                task_completion_rate
            );

            writer.WriteLine(line);
        }
    }

    // Helper: Menghitung Standard Deviation
    float CalculateStdDev(List<float> values)
    {
        if (values.Count <= 1) return 0f;

        float avg = values.Average();
        float sumSqDiff = values.Sum(d => (d - avg) * (d - avg));
        return Mathf.Sqrt(sumSqDiff / values.Count);
    }

    // --- YOLO INTEGRATION ---
    // Dipanggil oleh script YoloDetector.cs secara real-time
    public void UpdateYoloData(int classIndex, float confidence)
    {
        this.current_detected_class = classIndex;
        this.current_detected_conf = confidence;
    }
}