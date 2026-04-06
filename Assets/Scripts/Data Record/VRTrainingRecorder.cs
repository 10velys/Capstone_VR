using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class VRTrainingRecorder : MonoBehaviour
{
    public static VRTrainingRecorder Instance;

    [Header("Sensor References")]
    public Transform headCamera;
    public Transform rightController;

    [Header("Session Settings")]
    public int current_level = 1;

    [Tooltip("Kecepatan tangan di bawah nilai ini dianggap hesitation.")]
    public float hesitationThreshold = 0.05f;

    [Tooltip("Dipakai hanya untuk debug log YOLO umum.")]
    public float validDetectionThreshold = 0.2f;

    [Header("Kinematic Settings")]
    [Tooltip("Frame dengan dt terlalu kecil diabaikan agar tidak menghasilkan noise turunan.")]
    public float minValidDeltaTime = 0.005f;

    [Tooltip("Frame hitch besar akan di-reset agar jerk tidak meledak palsu.")]
    public float maxValidDeltaTime = 0.10f;

    [Tooltip("Semakin besar, velocity makin halus tapi makin lambat respons.")]
    public float velocitySmoothingTime = 0.08f;

    [Tooltip("Semakin besar, acceleration makin halus.")]
    public float accelerationSmoothingTime = 0.10f;

    [Tooltip("Clamp maksimum jerk agar spike ekstrem tidak merusak data.")]
    public float maxJerkClamp = 5000f;

    [Header("Debug")]
    public bool writeDebugLog = true;
    public bool writeMotionSummaryToDebug = false;
    public float motionDebugInterval = 1.0f;

    [Header("Task Completion")]
    [Tooltip("TRUE = boleh pakai fallback YOLO. FALSE = task hanya dari event gameplay.")]
    public bool useYoloFallbackCompletion = true;

    [Tooltip("Confidence minimal agar deteksi dihitung sebagai evidence task.")]
    public float yoloTaskConfidenceThreshold = 0.60f;

    [Tooltip("Cooldown antar evidence label yang sama agar tidak double count terlalu cepat.")]
    public float yoloEvidenceCooldown = 0.35f;

    [Tooltip("Jumlah evidence minimal untuk label success/rapih.")]
    public int requiredEvidencePerSuccessLabel = 2;

    private readonly string[] classLabels = new string[]
    {
        "bantal_rapih", "bantal_tidak_rapih", "selimut_rapih", "selimut_tidak_rapih",
        "sampah_tidak_rapih", "tempat_sampah", "sampah_rapih",
        "keranjang_kotor", "keranjang_bersih", "handuk_kotor", "handuk_bersih",
        "handuk_kotor_success", "handuk_bersih_success"
    };

    public enum TaskCategory { None, Bedding, Trash, Towel }

    // Success-only fallback IDs
    private const int LABEL_BANTAL_RAPIH = 0;
    private const int LABEL_SELIMUT_RAPIH = 2;
    private const int LABEL_SAMPAH_RAPIH = 6;
    private const int LABEL_HANDUK_KOTOR_SUCCESS = 11;
    private const int LABEL_HANDUK_BERSIH_SUCCESS = 12;

    private string session_id;
    private bool isRecording = false;
    private float startTime;
    private float lastSampleTime;
    private float nextMotionDebugTime;

    // Kinematic state
    private Vector3 lastHandPos;
    private Vector3 filteredVelocity;
    private Vector3 filteredAcceleration;

    private float currentVelInst;
    private float currentJerkInst;

    // Time-weighted feature accumulation
    private float sampledMotionTime;
    private float velocityIntegral;
    private float hesitationDuration;
    private float maxHandJerkObserved;

    // Head pitch running stats
    private int headPitchSampleCount;
    private float headPitchMean;
    private float headPitchM2;

    // Task state
    private HashSet<TaskCategory> completedCategories = new HashSet<TaskCategory>();
    private Dictionary<int, int> yoloEvidenceCounts = new Dictionary<int, int>();
    private Dictionary<int, float> lastEvidenceTimeByLabel = new Dictionary<int, float>();

    private string debugLogPath;

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

        ResetSessionState();

        isRecording = true;
        startTime = Time.time;
        lastSampleTime = Time.time;
        nextMotionDebugTime = Time.time + motionDebugInterval;

        if (rightController != null)
        {
            ResetKinematicChain(rightController.position);
        }

        if (writeDebugLog)
        {
            AppendToDebugLog($"=== RECORDING STARTED | {session_id} | level={current_level} ===");
        }

        Debug.Log($"Recording Started: {session_id}");
    }

    public void StopAndSave()
    {
        if (!isRecording) return;

        isRecording = false;
        ProcessAndSaveAggregation();

        if (writeDebugLog)
        {
            AppendToDebugLog($"=== RECORDING STOPPED | {session_id} ===");
        }
    }

    void Update()
    {
        if (!isRecording || rightController == null) return;

        float dt = Time.deltaTime;
        float now = Time.time;

        if (dt < minValidDeltaTime || dt > maxValidDeltaTime)
        {
            ResetKinematicChain(rightController.position);
            SampleHeadPitch();
            lastSampleTime = now;
            return;
        }

        Vector3 currentPos = rightController.position;

        // Raw velocity
        Vector3 rawVelocity = (currentPos - lastHandPos) / dt;

        // Smoothed velocity
        float velAlpha = AlphaFromTimeConstant(dt, velocitySmoothingTime);
        Vector3 newFilteredVelocity = Vector3.Lerp(filteredVelocity, rawVelocity, velAlpha);

        // Acceleration from smoothed velocity
        Vector3 rawAcceleration = (newFilteredVelocity - filteredVelocity) / dt;

        // Smoothed acceleration
        float accAlpha = AlphaFromTimeConstant(dt, accelerationSmoothingTime);
        Vector3 newFilteredAcceleration = Vector3.Lerp(filteredAcceleration, rawAcceleration, accAlpha);

        // Jerk from smoothed acceleration
        Vector3 rawJerk = (newFilteredAcceleration - filteredAcceleration) / dt;

        currentVelInst = newFilteredVelocity.magnitude;
        currentJerkInst = Mathf.Min(rawJerk.magnitude, maxJerkClamp);

        // Accumulate robust session features
        sampledMotionTime += dt;
        velocityIntegral += currentVelInst * dt;

        if (currentVelInst < hesitationThreshold)
            hesitationDuration += dt;

        if (currentJerkInst > maxHandJerkObserved)
            maxHandJerkObserved = currentJerkInst;

        // Head pitch sampled continuously
        SampleHeadPitch();

        // Commit state
        lastHandPos = currentPos;
        filteredVelocity = newFilteredVelocity;
        filteredAcceleration = newFilteredAcceleration;
        lastSampleTime = now;

        if (writeDebugLog && writeMotionSummaryToDebug && now >= nextMotionDebugTime)
        {
            AppendToDebugLog(
                $"MOTION | t={now - startTime:F2}s | vel={currentVelInst:F4} | jerk={currentJerkInst:F4} | " +
                $"hes={hesitationDuration:F2} | pitchStd={GetHeadPitchStd():F4}"
            );
            nextMotionDebugTime = now + motionDebugInterval;
        }
    }

    // ----------------------------------------------------------------------
    // TASK COMPLETION API
    // ----------------------------------------------------------------------
    public void MarkTrashCompleted() => MarkTaskCompleted(TaskCategory.Trash, "GameEvent");
    public void MarkBeddingCompleted() => MarkTaskCompleted(TaskCategory.Bedding, "GameEvent");
    public void MarkTowelCompleted() => MarkTaskCompleted(TaskCategory.Towel, "GameEvent");

    public void MarkTaskCompleted(TaskCategory category, string source = "Unknown")
    {
        if (!isRecording || category == TaskCategory.None) return;

        if (completedCategories.Add(category))
        {
            Debug.Log($"<color=green>TASK COMPLETED: {category} | source={source}</color>");
            if (writeDebugLog)
                AppendToDebugLog($"TASK_COMPLETED | {category} | source={source} | t={Time.time - startTime:F2}s");
        }
    }

    // ----------------------------------------------------------------------
    // YOLO CALLBACK
    // ----------------------------------------------------------------------
    public void UpdateYoloData(int classIndex, float confidence)
    {
        if (!isRecording) return;
        if (classIndex < 0 || classIndex >= classLabels.Length) return;

        TaskCategory detectedCategory = MapIdToCategory(classIndex);

        if (writeDebugLog && confidence >= validDetectionThreshold)
        {
            string name = classLabels[classIndex];
            AppendToDebugLog($"{Time.time - startTime:F1}s | {classIndex} | {name} | Cat: {detectedCategory} | {confidence:F2}");
        }

        if (!useYoloFallbackCompletion) return;
        if (confidence < yoloTaskConfidenceThreshold) return;

        TryAccumulateYoloTaskEvidence(classIndex);
    }

    private void TryAccumulateYoloTaskEvidence(int classIndex)
    {
        float now = Time.time;

        if (lastEvidenceTimeByLabel.TryGetValue(classIndex, out float lastTime))
        {
            if ((now - lastTime) < yoloEvidenceCooldown)
                return;
        }

        lastEvidenceTimeByLabel[classIndex] = now;

        if (!yoloEvidenceCounts.ContainsKey(classIndex))
            yoloEvidenceCounts[classIndex] = 0;

        yoloEvidenceCounts[classIndex]++;

        // Bedding fallback: butuh bantal_rapih DAN selimut_rapih
        if (!completedCategories.Contains(TaskCategory.Bedding))
        {
            int pillowCount = GetEvidenceCount(LABEL_BANTAL_RAPIH);
            int blanketCount = GetEvidenceCount(LABEL_SELIMUT_RAPIH);

            if (pillowCount >= requiredEvidencePerSuccessLabel &&
                blanketCount >= requiredEvidencePerSuccessLabel)
            {
                MarkTaskCompleted(TaskCategory.Bedding, "YOLO_Fallback");
            }
        }

        // Trash fallback: hanya dari sampah_rapih
        if (!completedCategories.Contains(TaskCategory.Trash))
        {
            int trashCount = GetEvidenceCount(LABEL_SAMPAH_RAPIH);
            if (trashCount >= requiredEvidencePerSuccessLabel)
            {
                MarkTaskCompleted(TaskCategory.Trash, "YOLO_Fallback");
            }
        }

        // Towel fallback: hanya dari label sukses
        if (!completedCategories.Contains(TaskCategory.Towel))
        {
            int towelSuccessCount =
                GetEvidenceCount(LABEL_HANDUK_KOTOR_SUCCESS) +
                GetEvidenceCount(LABEL_HANDUK_BERSIH_SUCCESS);

            if (towelSuccessCount >= requiredEvidencePerSuccessLabel)
            {
                MarkTaskCompleted(TaskCategory.Towel, "YOLO_Fallback");
            }
        }
    }

    private int GetEvidenceCount(int labelId)
    {
        return yoloEvidenceCounts.TryGetValue(labelId, out int count) ? count : 0;
    }

    private TaskCategory MapIdToCategory(int id)
    {
        if (id >= 0 && id <= 3) return TaskCategory.Bedding;
        if (id >= 4 && id <= 6) return TaskCategory.Trash;
        if (id >= 7 && id <= 12) return TaskCategory.Towel;
        return TaskCategory.None;
    }

    // ----------------------------------------------------------------------
    // FEATURE BUILDING
    // ----------------------------------------------------------------------

    // Untuk model ML (6 fitur saja)
    public double[] GetModelFeatureVector()
    {
        SessionFeatures f = BuildCurrentFeatures();

        return new double[]
        {
            current_level,
            f.avg_hand_velocity,
            f.max_hand_jerk,
            f.hesitation_time,
            f.focus_consistency,
            f.total_duration
        };
    }

    // Untuk debug / CSV / inspeksi manual (9 fitur, termasuk task flags)
    public double[] GetCurrentFeatureVector()
    {
        SessionFeatures f = BuildCurrentFeatures();

        return new double[]
        {
            current_level,
            f.avg_hand_velocity,
            f.max_hand_jerk,
            f.hesitation_time,
            f.focus_consistency,
            f.total_duration,
            f.task_trash,
            f.task_bed,
            f.task_towel
        };
    }

    private SessionFeatures BuildCurrentFeatures()
    {
        SessionFeatures f = new SessionFeatures();

        f.total_duration = Mathf.Max(0f, Time.time - startTime);
        f.avg_hand_velocity = sampledMotionTime > 0f ? (velocityIntegral / sampledMotionTime) : 0f;
        f.max_hand_jerk = maxHandJerkObserved;
        f.hesitation_time = hesitationDuration;
        f.focus_consistency = GetHeadPitchStd();

        f.task_trash = completedCategories.Contains(TaskCategory.Trash) ? 1 : 0;
        f.task_bed = completedCategories.Contains(TaskCategory.Bedding) ? 1 : 0;
        f.task_towel = completedCategories.Contains(TaskCategory.Towel) ? 1 : 0;

        return f;
    }

    private struct SessionFeatures
    {
        public float avg_hand_velocity;
        public float max_hand_jerk;
        public float hesitation_time;
        public float focus_consistency;
        public float total_duration;
        public int task_trash;
        public int task_bed;
        public int task_towel;
    }

    // ----------------------------------------------------------------------
    // SAVE
    // ----------------------------------------------------------------------
    private void ProcessAndSaveAggregation()
    {
        SessionFeatures f = BuildCurrentFeatures();

        string filePath = Path.Combine(Application.persistentDataPath, "Session_Summary.csv");
        bool writeHeader = !File.Exists(filePath);

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            if (writeHeader)
            {
                writer.WriteLine("session_id,current_level,avg_hand_velocity,max_hand_jerk,hesitation_time,focus_consistency,total_duration,task_trash,task_bed,task_towel");
            }

            string line = string.Format(
                "{0},{1},{2:F4},{3:F4},{4:F2},{5:F4},{6:F2},{7},{8},{9}",
                session_id,
                current_level,
                f.avg_hand_velocity,
                f.max_hand_jerk,
                f.hesitation_time,
                f.focus_consistency,
                f.total_duration,
                f.task_trash,
                f.task_bed,
                f.task_towel
            );

            writer.WriteLine(line);
        }

        Debug.Log($"Session Saved: {filePath}");

        if (writeDebugLog)
        {
            AppendToDebugLog(
                $"SUMMARY | level={current_level} | avgVel={f.avg_hand_velocity:F4} | maxJerk={f.max_hand_jerk:F4} | " +
                $"hes={f.hesitation_time:F2} | focusStd={f.focus_consistency:F4} | dur={f.total_duration:F2} | " +
                $"trash={f.task_trash} | bed={f.task_bed} | towel={f.task_towel}"
            );
        }
    }

    // ----------------------------------------------------------------------
    // INTERNAL HELPERS
    // ----------------------------------------------------------------------
    private void ResetSessionState()
    {
        completedCategories.Clear();
        yoloEvidenceCounts.Clear();
        lastEvidenceTimeByLabel.Clear();

        currentVelInst = 0f;
        currentJerkInst = 0f;

        sampledMotionTime = 0f;
        velocityIntegral = 0f;
        hesitationDuration = 0f;
        maxHandJerkObserved = 0f;

        headPitchSampleCount = 0;
        headPitchMean = 0f;
        headPitchM2 = 0f;
    }

    private void ResetKinematicChain(Vector3 currentPos)
    {
        lastHandPos = currentPos;
        filteredVelocity = Vector3.zero;
        filteredAcceleration = Vector3.zero;
        currentVelInst = 0f;
        currentJerkInst = 0f;
    }

    private void SampleHeadPitch()
    {
        if (headCamera == null) return;

        float pitch = NormalizeAngle(headCamera.eulerAngles.x);

        headPitchSampleCount++;
        float delta = pitch - headPitchMean;
        headPitchMean += delta / headPitchSampleCount;
        float delta2 = pitch - headPitchMean;
        headPitchM2 += delta * delta2;
    }

    private float GetHeadPitchStd()
    {
        if (headPitchSampleCount <= 1) return 0f;
        return Mathf.Sqrt(headPitchM2 / headPitchSampleCount);
    }

    private float NormalizeAngle(float angle)
    {
        if (angle > 180f) angle -= 360f;
        return angle;
    }

    private float AlphaFromTimeConstant(float dt, float timeConstant)
    {
        if (timeConstant <= 0f) return 1f;
        return 1f - Mathf.Exp(-dt / timeConstant);
    }

    private void AppendToDebugLog(string line)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(debugLogPath))
            {
                sw.WriteLine(line);
            }
        }
        catch
        {
            // sengaja diam agar game tidak crash hanya karena log gagal
        }
    }
}