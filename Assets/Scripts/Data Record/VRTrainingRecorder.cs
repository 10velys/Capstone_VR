using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class VRTrainingRecorder : MonoBehaviour
{
    public static VRTrainingRecorder Instance;

    [Header("Sensor References")]
    public Transform headCamera;
    public Transform rightController;

    [Header("Session Settings")]
    public int current_level = 1;
    public float hesitationThreshold = 0.05f;
    public float validDetectionThreshold = 0.2f;

    // Mapping ID sesuai label YOLO Anda
    private readonly string[] classLabels = new string[]
    {
        "bantal_rapih", "bantal_tidak_rapih", "selimut_rapih", "selimut_tidak_rapih",
        "sampah_tidak_rapih", "tempat_sampah", "sampah_rapih",
        "keranjang_kotor", "keranjang_bersih", "handuk_kotor", "handuk_bersih",
        "handuk_kotor_success", "handuk_bersih_success"
    };

    public enum TaskCategory { None, Bedding, Trash, Towel }

    private string session_id;
    private bool isRecording = false;
    private float startTime;
    private float nextRecordTime = 0f;

    // Variables for Physics tracking
    private Vector3 lastHandPos;
    private float currentVelInst;
    private float currentJerkInst;
    private Vector3 lastHandVel;
    private Vector3 lastHandAcc;

    private HashSet<TaskCategory> completedCategories = new HashSet<TaskCategory>();
    private List<RawDataPoint> rawDataLog = new List<RawDataPoint>();
    private string debugLogPath;

    private class RawDataPoint
    {
        public float hand_velocity_inst;
        public float hand_jerk_inst;
        public float head_pitch;
    }

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void StartRecording()
    {
        int sessionCounter = PlayerPrefs.GetInt("SessionCounter", 1);
        session_id = $"USER_{System.DateTime.Now:yyyyMMdd}_{sessionCounter:D3}";
        PlayerPrefs.SetInt("SessionCounter", sessionCounter + 1);
        PlayerPrefs.Save();

        debugLogPath = Path.Combine(Application.persistentDataPath, $"DEBUG_LOG_{session_id}.txt");
        // Reset state
        rawDataLog.Clear();
        completedCategories.Clear();
        isRecording = true;
        startTime = Time.time;
        nextRecordTime = startTime;

        if (rightController != null)
        {
            lastHandPos = rightController.position;
            lastHandVel = Vector3.zero;
            lastHandAcc = Vector3.zero;
        }

        Debug.Log($"Recording Started: {session_id}");
    }

    public void StopAndSave()
    {
        if (!isRecording) return;
        isRecording = false;
        ProcessAndSaveAggregation();
    }

    void Update()
    {
        if (!isRecording || rightController == null) return;

        // Physics Calculation
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

        // Periodic Logging (1Hz)
        if (Time.time >= nextRecordTime)
        {
            LogSnapshotInMemory();
            nextRecordTime = Time.time + 1.0f;
        }
    }

    // Dipanggil oleh YoloDetector setiap kali objek terdeteksi
    public void UpdateYoloData(int classIndex, float confidence)
    {
        if (!isRecording) return;

        // Validasi threshold dan index
        if (confidence >= validDetectionThreshold && classIndex >= 0 && classIndex < classLabels.Length)
        {
            TaskCategory detectedCategory = MapIdToCategory(classIndex);
            
            // Logika Task Completion (Langsung diproses di sini)
            if (detectedCategory != TaskCategory.None)
            {
                if (!completedCategories.Contains(detectedCategory))
                {
                    completedCategories.Add(detectedCategory);
                    Debug.Log($"<color=green>TASK COMPLETED: {detectedCategory}</color>");
                }
            }

            // Optional: Debug Log ke file (hanya jika confidence tinggi agar file tidak penuh sampah)
            if (confidence > 0.4f) 
            {
                string name = classLabels[classIndex];
                AppendToDebugLog($"{Time.time - startTime:F1}s | {classIndex} | {name} | Cat: {detectedCategory} | {confidence:F2}");
            }
        }
    }

    TaskCategory MapIdToCategory(int id)
    {
        if (id >= 0 && id <= 3) return TaskCategory.Bedding;
        if (id >= 4 && id <= 6) return TaskCategory.Trash;
        if (id >= 7 && id <= 12) return TaskCategory.Towel;
        return TaskCategory.None;
    }

    void LogSnapshotInMemory()
    {
        float pitch = (headCamera != null) ? headCamera.eulerAngles.x : 0f;
        if (pitch > 180) pitch -= 360;

        rawDataLog.Add(new RawDataPoint
        {
            hand_velocity_inst = currentVelInst,
            hand_jerk_inst = currentJerkInst,
            head_pitch = pitch
        });
    }

    void ProcessAndSaveAggregation()
    {
        if (rawDataLog.Count == 0) return;

        float avg_hand_velocity = rawDataLog.Average(x => x.hand_velocity_inst);
        float max_hand_jerk = rawDataLog.Max(x => x.hand_jerk_inst);
        float hesitation_time = rawDataLog.Count(x => x.hand_velocity_inst < hesitationThreshold); // Asumsi 1 data = 1 detik
        float focus_consistency = CalculateStdDev(rawDataLog.Select(x => x.head_pitch).ToList());
        float total_duration = Time.time - startTime;

        int task_bed = completedCategories.Contains(TaskCategory.Bedding) ? 1 : 0;
        int task_trash = completedCategories.Contains(TaskCategory.Trash) ? 1 : 0;
        int task_towel = completedCategories.Contains(TaskCategory.Towel) ? 1 : 0;

        string filePath = Path.Combine(Application.persistentDataPath, "Session_Summary.csv");
        bool writeHeader = !File.Exists(filePath);

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            if (writeHeader) writer.WriteLine("session_id,current_level,avg_hand_velocity,max_hand_jerk,hesitation_time,focus_consistency,total_duration,task_trash,task_bed,task_towel");

            string line = string.Format("{0},{1},{2:F4},{3:F4},{4:F2},{5:F4},{6:F2},{7},{8},{9}",
                session_id, current_level, avg_hand_velocity, max_hand_jerk, hesitation_time, focus_consistency, total_duration,
                task_trash, task_bed, task_towel);
            writer.WriteLine(line);
        }
        Debug.Log($"Session Saved: {filePath}");
    }

    float CalculateStdDev(List<float> values)
    {
        if (values.Count <= 1) return 0f;
        float avg = values.Average();
        float sumSqDiff = values.Sum(d => (d - avg) * (d - avg));
        return Mathf.Sqrt(sumSqDiff / values.Count);
    }

    void AppendToDebugLog(string line)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(debugLogPath))
            {
                sw.WriteLine(line);
            }
        }
        catch { }
    }
}