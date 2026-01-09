using UnityEngine;
using Unity.InferenceEngine; // Namespace Paket
using System.Collections.Generic;
using System.Linq;

public class YoloDetector : MonoBehaviour
{
    [Header("Model Settings")]
    public ModelAsset modelAsset;
    public RenderTexture inputTexture; 
    public string[] labels; 

    [Header("Inference Settings")]
    [Range(0f, 1f)] public float confidenceThreshold = 0.5f;
    [Range(0f, 1f)] public float iouThreshold = 0.4f;

    [Header("Integration")]
    public VRTrainingRecorder recorder; 

    // --- PERBAIKAN DI SINI ---
    private Model runtimeModel;
    private Worker worker; // Menggunakan class konkrit 'Worker' (Bukan IWorker)
    
    private const int ImageSize = 640; 

    void Start()
    {
        if (modelAsset == null || inputTexture == null)
        {
            Debug.LogError("[YOLO] Model Asset atau Input Texture belum di-assign!");
            return;
        }

        // 1. Load Model
        runtimeModel = ModelLoader.Load(modelAsset);

        // 2. Buat Worker
        // Karena IWorker tidak ada, kita gunakan constructor langsung 'new Worker'
        // Ini adalah cara standar di beberapa versi Inference Engine
        worker = new Worker(runtimeModel, BackendType.GPUCompute);

        Debug.Log($"[YOLO] Ready. Backend: {worker.backendType}");
    }

    float timer = 0;
    float detectionInterval = 0.2f;

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

        // 1. Siapkan Tensor Kosong dengan Ukuran Pasti (1, 640, 640, 3)
        // TensorShape ini yang akan menjadi acuan ukuran (Source of Truth)
        using var inputTensor = new Tensor<float>(new TensorShape(1, ImageSize, ImageSize, 3));

        // 2. Siapkan Transform (Tanpa SetDimensions)
        // Cukup buat instance baru, dia otomatis menyesuaikan resize ke ukuran inputTensor di atas
        var transform = new TextureTransform(); 

        // 3. Masukkan data Texture ke dalam Tensor
        TextureConverter.ToTensor(inputTexture, inputTensor, transform);

        // 4. Eksekusi Model
        worker.Schedule(inputTensor);

        // 5. Ambil Output
        var outputTensor = worker.PeekOutput() as Tensor<float>;

        if (outputTensor == null) return;

        // Download ke CPU
        using var cpuTensor = outputTensor.ReadbackAndClone();
        
        // Ambil data array
        var dataRef = cpuTensor.dataOnBackend.Download<float>(cpuTensor.shape.length);
        float[] outputArray = dataRef.ToArray();

        // 6. Proses
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