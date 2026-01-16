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

    private readonly string[] classLabels = new string[]
    {
        "bantal_rapih",         // 0
        "bantal_tidak_rapih",   // 1
        "selimut_rapih",        // 2 
        "selimut_tidak_rapih",  // 3 
        "sampah_tidak_rapih",   // 4
        "tempat_sampah",        // 5
        "sampah_rapih",         // 6
        "keranjang_kotor",      // 7
        "keranjang_bersih",     // 8
        "handuk_kotor",         // 9
        "handuk_bersih",        // 10
        "handuk_kotor_success", // 11
        "handuk_bersih_success" // 12
    };

    public enum TaskCategory { None, Bedding, Trash, Towel }

    private string session_id;
    private bool isRecording = false;
    private float startTime;
    private float nextRecordTime = 0f;

    private Vector3 lastHandPos;
    private float currentVelInst;
    private float currentJerkInst;
    private Vector3 lastHandVel;
    private Vector3 lastHandAcc;

    public int current_detected_class = -1;
    public float current_detected_conf = 0f;

    private HashSet<TaskCategory> completedCategories = new HashSet<TaskCategory>();
    private List<RawDataPoint> rawDataLog = new List<RawDataPoint>();
    
    private string debugLogPath;

    private class RawDataPoint {
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
        File.WriteAllText(debugLogPath, "TIMESTAMP | RAW ID | NAME | CONFIDENCE | RESULT\n");

        rawDataLog.Clear();
        completedCategories.Clear();
        isRecording = true;
        startTime = Time.time;
        nextRecordTime = startTime;

        if (rightController != null) {
            lastHandPos = rightController.position;
            lastHandVel = Vector3.zero;
            lastHandAcc = Vector3.zero;
        }
        
        Debug.Log($"Recording Started. Log File: {debugLogPath}");
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

        float dt = Time.deltaTime;
        if (dt > 0) {
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

        if (current_detected_class >= 0 && current_detected_class < classLabels.Length)
        {
            if (current_detected_conf >= validDetectionThreshold)
            {
                TaskCategory detectedCategory = MapIdToCategory(current_detected_class);
                if (detectedCategory != TaskCategory.None)
                {
                    if (!completedCategories.Contains(detectedCategory))
                    {
                        completedCategories.Add(detectedCategory);
                        AppendToDebugLog($"TASK COMPLETE: {detectedCategory}");
                    }
                }
            }
        }

        if (Time.time >= nextRecordTime) {
            LogSnapshotInMemory();
            nextRecordTime = Time.time + 1.0f;
        }
    }

    TaskCategory MapIdToCategory(int id)
    {
        if (id >= 0 && id <= 3) return TaskCategory.Bedding;
        
        if (id >= 4 && id <= 6) return TaskCategory.Trash;
        
        if (id >= 7 && id <= 12) return TaskCategory.Towel;

        return TaskCategory.None;
    }

    public void UpdateYoloData(int classIndex, float confidence)
    {
        this.current_detected_class = classIndex;
        this.current_detected_conf = confidence;

        if (isRecording && confidence > 0.1f && classIndex >= 0)
        {
            string name = (classIndex < classLabels.Length) ? classLabels[classIndex] : "Unknown";
            TaskCategory category = MapIdToCategory(classIndex);
            string status = (confidence >= validDetectionThreshold) ? "VALID" : "REJECTED (Low Conf)";
            
            string logLine = $"{Time.time - startTime:F1}s | {classIndex} | {name} | Category: {category} | {confidence:F2} | {status}";
            AppendToDebugLog(logLine);
            Debug.Log(logLine); // Tambahkan ini untuk melihat di Console
        }
    }

    void AppendToDebugLog(string line)
    {
        try {
            using (StreamWriter sw = File.AppendText(debugLogPath)) {
                sw.WriteLine(line);
            }
        } catch {}
    }

    void LogSnapshotInMemory()
    {
        float pitch = (headCamera != null) ? headCamera.eulerAngles.x : 0f;
        if (pitch > 180) pitch -= 360;
        rawDataLog.Add(new RawDataPoint {
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
        float hesitation_time = rawDataLog.Count(x => x.hand_velocity_inst < hesitationThreshold) * 1.0f;
        float focus_consistency = CalculateStdDev(rawDataLog.Select(x => x.head_pitch).ToList());
        float total_duration = Time.time - startTime;

        int task_bed   = completedCategories.Contains(TaskCategory.Bedding) ? 1 : 0;
        int task_trash = completedCategories.Contains(TaskCategory.Trash)   ? 1 : 0;
        int task_towel = completedCategories.Contains(TaskCategory.Towel)   ? 1 : 0;

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
    }

    float CalculateStdDev(List<float> values)
    {
        if (values.Count <= 1) return 0f;
        float avg = values.Average();
        float sumSqDiff = values.Sum(d => (d - avg) * (d - avg));
        return Mathf.Sqrt(sumSqDiff / values.Count);
    }
}