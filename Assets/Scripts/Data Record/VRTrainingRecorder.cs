using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Wajib ada untuk fungsi Distinct(), Count(), Average()

public class VRTrainingRecorder : MonoBehaviour
{
    public static VRTrainingRecorder Instance;

    [Header("Sensor References")]
    public Transform headCamera;
    public Transform rightController;

    [Header("Session Settings")]
    public int current_level = 1; 
    public float hesitationThreshold = 0.05f; 
    
    // Threshold minimal confidence agar dianggap tugas VALID selesai.
    // PENTING: Atur nilai ini di Inspector Unity (misal: 0.5 atau 0.6)
    public float validDetectionThreshold = 0.5f; 

    // --- STATE VARIABLES ---
    private string session_id;
    private bool isRecording = false;
    private float startTime;
    private float nextRecordTime = 0f;

    // --- PHYSICS TEMP VARS ---
    private Vector3 lastHandPos;
    private float currentVelInst; 
    private float currentJerkInst; 
    private Vector3 lastHandVel;
    private Vector3 lastHandAcc;

    // --- YOLO INPUT (Updated by YoloDetector) ---
    // Default -1 artinya tidak ada object terdeteksi
    private int current_detected_class = -1; 
    private float current_detected_conf = 0f;

    // --- TEMPORARY RAW DATA STORAGE (IN MEMORY) ---
    // Class untuk menyimpan snapshot data per detik (Data Logging)
    private class RawDataPoint
    {
        public float hand_velocity_inst;
        public float hand_jerk_inst;
        public float head_pitch;
        
        // Kita butuh Class ID untuk tahu objek mana yang selesai (Bantal/Sampah/Handuk)
        public int detected_class; 
        public float detected_conf;
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
        rawDataLog.Clear(); 
        isRecording = true;
        startTime = Time.time;
        nextRecordTime = startTime; 

        // 3. Reset Physics
        if (rightController != null)
        {
            lastHandPos = rightController.position;
            lastHandVel = Vector3.zero;
            lastHandAcc = Vector3.zero;
        }

        Debug.Log($"[RECORDER] Session {session_id} Started.");
    }

    public void StopAndSave()
    {
        if (!isRecording) return;
        isRecording = false;

        // Proses Agregasi Data dari Memory -> CSV
        ProcessAndSaveAggregation();

        Debug.Log($"[RECORDER] Session Stopped. Aggregated Data Saved.");
    }

    void Update()
    {
        if (!isRecording || rightController == null) return;

        // A. HITUNG FISIKA (Real-time per frame)
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

        // B. DATA LOGGING (1 Detik Sekali - Disimpan di Memory Saja)
        if (Time.time >= nextRecordTime)
        {
            LogSnapshotInMemory();
            nextRecordTime = Time.time + 1.0f; 
        }
    }

    void LogSnapshotInMemory()
    {
        float pitch = 0f;
        if (headCamera != null)
        {
            pitch = headCamera.eulerAngles.x;
            if (pitch > 180) pitch -= 360; 
        }

        RawDataPoint point = new RawDataPoint
        {
            hand_velocity_inst = currentVelInst,
            hand_jerk_inst = currentJerkInst,
            head_pitch = pitch,
            // Simpan data YOLO saat ini (Data Logging)
            detected_class = current_detected_class, 
            detected_conf = current_detected_conf
        };

        rawDataLog.Add(point);
    }

    // --- LOGIKA BARU AGREGASI (FINAL REVISI) ---
    void ProcessAndSaveAggregation()
    {
        if (rawDataLog.Count == 0) return;

        // 1. avg_hand_velocity
        float avg_hand_velocity = rawDataLog.Average(x => x.hand_velocity_inst);

        // 2. max_hand_jerk
        float max_hand_jerk = rawDataLog.Max(x => x.hand_jerk_inst);

        // 3. hesitation_time
        int hesitationCount = rawDataLog.Count(x => x.hand_velocity_inst < hesitationThreshold);
        float hesitation_time = hesitationCount * 1.0f; 

        // 4. focus_consistency
        float focus_consistency = CalculateStdDev(rawDataLog.Select(x => x.head_pitch).ToList());

        // 5. total_duration
        float total_duration = Time.time - startTime;

        // --- 6. TASK COMPLETION RATE ---
        // Logika: Ambil ID unik yang confidence-nya tinggi, lalu bagi dengan Total Task (3).
        
        var validUniqueObjects = rawDataLog
            .Where(x => x.detected_conf >= validDetectionThreshold && x.detected_class != -1)
            .Select(x => x.detected_class)
            .Distinct() // Hapus duplikat (misal: Bantal, Bantal, Sampah -> jadi {Bantal, Sampah})
            .ToList();

        float uniqueCount = validUniqueObjects.Count; // Jumlah tugas selesai (0, 1, 2, atau 3)
        float totalTasks = 3.0f; // Total task yang harus dikerjakan

        // Rumus Normalisasi: (Jumlah Selesai / 3). 
        // Hasilnya: 0.0, 0.33, 0.67, atau 1.0
        float task_completion_rate = uniqueCount / totalTasks;

        // Debugging di Console Unity
        string detectedIDs = string.Join(", ", validUniqueObjects);
        Debug.Log($"[AGREGASI] Selesai: {uniqueCount}/{totalTasks}. Rate: {task_completion_rate:F2} (Class ID: {detectedIDs})");

        // --- 7. TULIS KE CSV ---
        string filePath = Path.Combine(Application.persistentDataPath, "Session_Summary.csv");
        
        // Cek apakah perlu nulis header (jika file baru dibuat)
        bool writeHeader = !File.Exists(filePath);

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            if (writeHeader)
            {
                writer.WriteLine("session_id,current_level,avg_hand_velocity,max_hand_jerk,hesitation_time,focus_consistency,total_duration,task_completion_rate");
            }

            // PERUBAHAN PENTING: Format {7:F2} agar angka desimal muncul (misal 0.67)
            string line = string.Format("{0},{1},{2:F4},{3:F4},{4:F2},{5:F4},{6:F2},{7:F2}", 
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

    float CalculateStdDev(List<float> values)
    {
        if (values.Count <= 1) return 0f;
        float avg = values.Average();
        float sumSqDiff = values.Sum(d => (d - avg) * (d - avg));
        return Mathf.Sqrt(sumSqDiff / values.Count);
    }

    public void UpdateYoloData(int classIndex, float confidence)
    {
        this.current_detected_class = classIndex;
        this.current_detected_conf = confidence;
    }
}