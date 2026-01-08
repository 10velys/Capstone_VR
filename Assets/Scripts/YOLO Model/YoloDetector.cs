using UnityEngine;

using System.Collections.Generic;
using System.Linq;

public class YoloDetector : MonoBehaviour
{
    [Header("Model Settings")]
    public Unity.InferenceEngine.ModelAsset modelAsset;
    public RenderTexture inputTexture; 
    public string[] labels; 

    [Header("Inference Settings")]
    [Range(0f, 1f)] public float confidenceThreshold = 0.5f;
    [Range(0f, 1f)] public float iouThreshold = 0.4f;

    [Header("Integration")]
    public VRTrainingRecorder recorder; 

    // Sentis 2.4.1 menggunakan Worker (BUKAN IWorker!)
    private Unity.InferenceEngine.Model runtimeModel;
    private Unity.InferenceEngine.Worker worker; // <--- INI YANG BENAR UNTUK SENTIS 2.4.1
    
    // Konstanta YOLOv8 standar
    private const int ImageSize = 640; 

    void Start()
    {
        if (modelAsset == null || inputTexture == null)
        {
            Debug.LogError("[YOLO] Model atau Input Texture belum dipasang!");
            return;
        }

        // 1. Load Model - Sentis 2.4.1
        runtimeModel = Unity.InferenceEngine.ModelLoader.Load(modelAsset);

        // 2. Buat Worker - Sentis 2.4.1 API (tanpa WorkerFactory)
        worker = new Unity.InferenceEngine.Worker(runtimeModel, Unity.InferenceEngine.BackendType.GPUCompute);

        Debug.Log("[YOLO] Model Loaded & Ready (Sentis 2.4.1)");
    }

    // Timer agar tidak memberatkan VR
    float timer = 0;
    float detectionInterval = 0.2f; // Deteksi 5 kali per detik

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= detectionInterval)
        {
            RunInference();
            timer = 0;
        }
    }

    void RunInference()
    {
        if (worker == null) return;

        // 3. Convert Texture ke Tensor - Sentis 2.4.1
        using var inputTensor = Unity.InferenceEngine.TextureConverter.ToTensor(inputTexture, width: ImageSize, height: ImageSize, channels: 3);

        // 4. Jalankan Model
        worker.Schedule(inputTensor);

        // 5. Ambil Output - Sentis 2.4.1 API
        var outputTensor = worker.PeekOutput() as Unity.InferenceEngine.Tensor<float>;

        // Download dari GPU ke CPU - Sentis 2.4.1 menggunakan ReadbackAndClone
        using var cpuTensor = outputTensor.ReadbackAndClone();
        
        // Ambil data sebagai array - gunakan length bukan shape
        var downloadedData = cpuTensor.dataOnBackend.Download<float>(cpuTensor.shape.length);
        float[] outputArray = downloadedData.ToArray();

        // 6. Proses Data Mentah
        ProcessYoloOutput(outputArray);
    }

    void ProcessYoloOutput(float[] data)
    {
        int numClasses = labels.Length;
        int numProposals = 8400; 

        List<Detection> detections = new List<Detection>();

        for (int i = 0; i < numProposals; i++)
        {
            float maxScore = 0f;
            int maxClassIndex = -1;

            for (int c = 0; c < numClasses; c++)
            {
                int index = ((4 + c) * numProposals) + i;
                float score = data[index];

                if (score > maxScore)
                {
                    maxScore = score;
                    maxClassIndex = c;
                }
            }

            if (maxScore > confidenceThreshold)
            {
                float x = data[(0 * numProposals) + i];
                float y = data[(1 * numProposals) + i];
                float w = data[(2 * numProposals) + i];
                float h = data[(3 * numProposals) + i];

                float xMin = x - (w / 2);
                float yMin = y - (h / 2);

                detections.Add(new Detection
                {
                    classId = maxClassIndex,
                    score = maxScore,
                    box = new Rect(xMin, yMin, w, h)
                });
            }
        }

        var finalDetections = DoNMS(detections);

        if (finalDetections.Count > 0)
        {
            Detection best = finalDetections[0];
            if (recorder != null)
            {
                recorder.UpdateYoloData(best.classId, best.score);
            }
        }
        else
        {
            if (recorder != null) recorder.UpdateYoloData(-1, 0f);
        }
    }

    List<Detection> DoNMS(List<Detection> inputDetections)
    {
        List<Detection> results = new List<Detection>();
        inputDetections.Sort((a, b) => b.score.CompareTo(a.score));

        while (inputDetections.Count > 0)
        {
            Detection current = inputDetections[0];
            results.Add(current);
            inputDetections.RemoveAt(0);

            for (int i = inputDetections.Count - 1; i >= 0; i--)
            {
                float iou = GetIoU(current.box, inputDetections[i].box);
                if (iou > iouThreshold)
                {
                    inputDetections.RemoveAt(i);
                }
            }
        }
        return results;
    }

    float GetIoU(Rect boxA, Rect boxB)
    {
        float xA = Mathf.Max(boxA.x, boxB.x);
        float yA = Mathf.Max(boxA.y, boxB.y);
        float xB = Mathf.Min(boxA.x + boxA.width, boxB.x + boxB.width);
        float yB = Mathf.Min(boxA.y + boxA.height, boxB.y + boxB.height);

        float interArea = Mathf.Max(0, xB - xA) * Mathf.Max(0, yB - yA);
        float unionArea = (boxA.width * boxA.height) + (boxB.width * boxB.height) - interArea;

        return interArea / unionArea;
    }

    void OnDestroy()
    {
        worker?.Dispose();
    }

    class Detection
    {
        public int classId;
        public float score;
        public Rect box;
    }
}