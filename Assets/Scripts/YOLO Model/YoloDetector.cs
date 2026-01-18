using UnityEngine;
using Unity.InferenceEngine;
using System.Collections;
using System.Collections.Generic;

public class YoloDetector : MonoBehaviour
{
    [Header("Model Settings")]
    public ModelAsset modelAsset;
    public RenderTexture inputTexture;
    public string[] labels;

    [Header("Inference Settings")]
    [Range(0f, 1f)] public float confidenceThreshold = 0.25f;
    [Range(0f, 1f)] public float iouThreshold = 0.45f;
    public float detectionInterval = 0.5f;

    [Header("Integration")]
    public VRTrainingRecorder recorder;

    private Model runtimeModel;
    private Worker worker;
    
    // Optimasi: Turunkan resolusi internal AI (tidak mempengaruhi visual user)
    // 320px jauh lebih ringan dari 640px dan cukup untuk deteksi objek besar (kasur/sampah)
    private const int ImageSize = 320; 

    private RenderTexture scaledRT;
    private Tensor<float> inputTensor;
    private float[] cachedOutputData; 
    private List<Detection> cachedDetections;
    private List<Detection> finalDetections;

    void Start()
    {
        if (modelAsset == null || inputTexture == null)
        {
            this.enabled = false;
            return;
        }

        runtimeModel = ModelLoader.Load(modelAsset);
        worker = new Worker(runtimeModel, BackendType.GPUCompute);

        // Alokasi memori di awal (Pooling) untuk mencegah lag saat main
        scaledRT = new RenderTexture(ImageSize, ImageSize, 0, RenderTextureFormat.ARGB32);
        
        // Pre-allocate lists
        cachedDetections = new List<Detection>(50);
        finalDetections = new List<Detection>(50);
        
        // Pre-allocate buffer tensor (sesuaikan ukuran output model Anda)
        // 8400 proposals * (4 box + classes)
        int outputSize = 8400 * (4 + labels.Length);
        cachedOutputData = new float[outputSize];

        StartCoroutine(InferenceLoop());
    }

    IEnumerator InferenceLoop()
    {
        yield return new WaitForSeconds(1.0f);

        while (true)
        {
            yield return StartCoroutine(RunInferenceRoutine());
            yield return new WaitForSeconds(detectionInterval);
        }
    }

    IEnumerator RunInferenceRoutine()
    {
        if (worker == null || inputTexture == null) yield break;

        // Step 1: Blit (Copy Texture)
        Graphics.Blit(inputTexture, scaledRT);
        
        // Step 2: Convert to Tensor
        // Kita dispose manual setiap frame untuk keamanan memori GPU, 
        // tapi kita lakukan di frame terpisah
        inputTensor = new Tensor<float>(new TensorShape(1, 3, ImageSize, ImageSize));
        var transform = new TextureTransform();
        transform.SetDimensions(ImageSize, ImageSize, 3);
        TextureConverter.ToTensor(scaledRT, inputTensor, transform);
        
        // Jeda 1 frame agar CPU bisa nafas
        yield return null; 

        // Step 3: Schedule Worker
        worker.Schedule(inputTensor);
        inputTensor.Dispose(); // Langsung buang referensi tensor input

        // Step 4: Tunggu GPU selesai (Non-blocking wait)
        // Kita tunggu sampai GPU benar-benar idle
        yield return null; 

        // Step 5: Readback Output
        var outputTensor = worker.PeekOutput() as Tensor<float>;
        if (outputTensor == null) yield break;

        // Download data ke array yang sudah disiapkan (Zero Allocation)
        using var cpuTensor = outputTensor.ReadbackAndClone();
        var dataRef = cpuTensor.dataOnBackend.Download<float>(cpuTensor.shape.length);
        
        // Copy manual ke cached array untuk menghindari pembuatan array baru
        Unity.Collections.NativeArray<float>.Copy(dataRef, cachedOutputData, cachedOutputData.Length);
        
        // Step 6: Process Data (Di frame berikutnya lagi agar motion tetap smooth)
        yield return null;
        ProcessYoloOutput(cachedOutputData);
    }

    void ProcessYoloOutput(float[] data)
    {
        cachedDetections.Clear();
        int numClasses = labels.Length;
        int numProposals = 8400; 

        for (int i = 0; i < numProposals; i++)
        {
            float maxScore = 0f;
            int maxClassIndex = -1;

            for (int c = 0; c < numClasses; c++)
            {
                int index = ((4 + c) * numProposals) + i;
                // Safety check array bounds
                if (index >= data.Length) continue;

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

                // Reuse object detection jika memungkinkan, atau struct (disini new class ringan)
                cachedDetections.Add(new Detection
                {
                    classId = maxClassIndex,
                    score = maxScore,
                    box = new Rect(xMin, yMin, w, h)
                });
            }
        }

        DoNMS(cachedDetections);

        if (recorder != null && finalDetections.Count > 0)
        {
            foreach (var det in finalDetections)
            {
                recorder.UpdateYoloData(det.classId, det.score);
            }
        }
    }

    void DoNMS(List<Detection> inputDetections)
    {
        finalDetections.Clear();
        inputDetections.Sort((a, b) => b.score.CompareTo(a.score));

        while (inputDetections.Count > 0)
        {
            Detection current = inputDetections[0];
            finalDetections.Add(current);
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
        StopAllCoroutines();
        worker?.Dispose();
        if (scaledRT != null) scaledRT.Release();
    }

    class Detection
    {
        public int classId;
        public float score;
        public Rect box;
    }
}