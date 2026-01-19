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
    [Range(0f, 1f)] public float confidenceThreshold = 0.4f; // Naikkan threshold agar lebih ringan
    [Range(0f, 1f)] public float iouThreshold = 0.45f;
    [Range(0.2f, 2.0f)] public float detectionInterval = 0.5f; // Range agar tidak bisa diset 0.1 di Inspector

    [Header("Integration")]
    public VRTrainingRecorder recorder;

    private Model runtimeModel;
    private Worker worker;
    
    // Internal resolution (320px cukup untuk Quest)
    private const int ImageSize = 320; 

    private RenderTexture scaledRT;
    private Tensor<float> inputTensor;
    private float[] cachedOutputData; 
    private List<Detection> cachedDetections;
    private List<Detection> finalDetections;

    private bool isInitializationSuccess = false;

    void Start()
    {
        // Validasi awal
        if (modelAsset == null || inputTexture == null)
        {
            Debug.LogError("[YOLO] Model atau Input Texture belum dipasang!");
            this.enabled = false;
            return;
        }

        try 
        {
            runtimeModel = ModelLoader.Load(modelAsset);
            // Gunakan GPUCompute untuk Quest
            worker = new Worker(runtimeModel, BackendType.GPUCompute);

            // Alokasi Memori Sekali Saja (Pooling)
            scaledRT = new RenderTexture(ImageSize, ImageSize, 0, RenderTextureFormat.ARGB32);
            cachedDetections = new List<Detection>(50);
            finalDetections = new List<Detection>(50);
            
            // Output size: 8400 boxes * (4 coords + class probabilities)
            int outputSize = 8400 * (4 + labels.Length);
            cachedOutputData = new float[outputSize];

            isInitializationSuccess = true;
            StartCoroutine(InferenceLoop());
        }
        catch (System.Exception e)
        {
            Debug.LogError($"[YOLO] Error init: {e.Message}");
        }
    }

    IEnumerator InferenceLoop()
    {
        // Tunggu 3 detik di awal agar game stabil dulu (rendering world selesai)
        yield return new WaitForSeconds(3.0f);

        WaitForSeconds waitInterval = new WaitForSeconds(detectionInterval);

        while (true)
        {
            // DYNAMIC THROTTLING:
            // Jika FPS sedang drop (lag), JANGAN jalankan AI. Prioritaskan kenyamanan mata user.
            float currentFPS = 1.0f / Time.smoothDeltaTime;
            if (currentFPS > 65.0f) // Hanya jalan jika FPS aman (di atas 65)
            {
                yield return StartCoroutine(RunInferenceRoutine());
            }
            else
            {
                // Jika lag, skip frame ini, coba lagi nanti
                yield return null; 
            }

            // Gunakan interval variable agar update realtime jika diubah di inspector
            yield return new WaitForSeconds(detectionInterval); 
        }
    }

    IEnumerator RunInferenceRoutine()
    {
        if (!isInitializationSuccess) yield break;

        // --- STEP 1: Copy & Resize Texture (Ringan) ---
        Graphics.Blit(inputTexture, scaledRT);
        
        // --- STEP 2: Convert to Tensor (Lumayan Berat) ---
        inputTensor = new Tensor<float>(new TensorShape(1, 3, ImageSize, ImageSize));
        var transform = new TextureTransform();
        transform.SetDimensions(ImageSize, ImageSize, 3);
        TextureConverter.ToTensor(scaledRT, inputTensor, transform);
        
        // Jeda 1 frame untuk memberi napas CPU
        yield return null; 

        // --- STEP 3: GPU Execution (Berat di GPU) ---
        worker.Schedule(inputTensor);
        inputTensor.Dispose(); // Langsung buang reference

        // Tunggu 1 frame lagi. Biarkan GPU bekerja sambil Unity render game.
        yield return null; 

        // --- STEP 4: Readback (Paling Berat - Potensi Lag Disini) ---
        var outputTensor = worker.PeekOutput() as Tensor<float>;
        if (outputTensor == null) yield break;

        // Kita tarik data. Dengan yield return null sebelumnya, harapannya GPU sudah selesai.
        using var cpuTensor = outputTensor.ReadbackAndClone();
        var dataRef = cpuTensor.dataOnBackend.Download<float>(cpuTensor.shape.length);
        
        // Copy ke buffer kita
        Unity.Collections.NativeArray<float>.Copy(dataRef, cachedOutputData, cachedOutputData.Length);
        
        // --- STEP 5: Process Logic (Pindah ke frame berikutnya biar smooth) ---
        yield return null;
        ProcessYoloOutput(cachedOutputData);
    }

    void ProcessYoloOutput(float[] data)
    {
        cachedDetections.Clear();
        int numClasses = labels.Length;
        int numProposals = 8400; 

        // Loop optimized
        for (int i = 0; i < numProposals; i++)
        {
            float maxScore = 0f;
            int maxClassIndex = -1;

            // Cari class dengan score tertinggi
            for (int c = 0; c < numClasses; c++)
            {
                int index = ((4 + c) * numProposals) + i;
                if (index >= data.Length) break;

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

                cachedDetections.Add(new Detection
                {
                    classId = maxClassIndex,
                    score = maxScore,
                    box = new Rect(x - w/2, y - h/2, w, h)
                });
            }
        }

        DoNMS(cachedDetections);

        // Kirim data ke Recorder (Hanya jika ada deteksi valid)
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
        if (inputDetections.Count == 0) return;

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