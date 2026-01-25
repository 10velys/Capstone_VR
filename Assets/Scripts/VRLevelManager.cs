using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; 

public class VRLevelManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject mainMenuCanvas;       
    public GameObject levelCompleteCanvas;  

    [Header("AI Result Buttons")]
    public GameObject btnNextLevel;         
    public GameObject btnRetry;             
    
    [Header("AI Result Texts")]
    public TextMeshProUGUI resultText;      // Judul "LEVEL COMPLETED / FAILED"
    
    // HAPUS: public TextMeshProUGUI confidenceText; (Sesuai permintaan)
    
    public TextMeshProUGUI feedbackText;    // Text untuk Pesan Personalisasi AI

    public static bool isRestartingLevel1 = false;

    void Start()
    {
        // --- LOGIKA MENU LEVEL 1 ---
        if (SceneManager.GetActiveScene().name == "VR Basic")
        {
            if (isRestartingLevel1)
            {
                if (mainMenuCanvas != null) mainMenuCanvas.SetActive(false);
                isRestartingLevel1 = false; 
            }
            else
            {
                if (mainMenuCanvas != null) mainMenuCanvas.SetActive(true);
            }
        }
        else
        {
            if (mainMenuCanvas != null) mainMenuCanvas.SetActive(false);
        }

        if (levelCompleteCanvas != null) levelCompleteCanvas.SetActive(false);
    }

    public void SelectLevel(string levelName)
    {
        if (levelName == "VR Basic")
        {
            if (mainMenuCanvas != null) mainMenuCanvas.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(levelName);
        }
    }

    // --- FUNGSI SAAT TASK SELESAI ---
    // Parameter confidence tetap diterima agar tidak error dipanggil GlobalRoomManager, 
    // tapi tidak kita gunakan di dalam fungsi.
    public void ShowLevelCompleteUI(bool isPassed, double confidence, string feedbackMsg)
    {
        // 1. Matikan menu utama, nyalakan panel hasil DULUAN
        if (mainMenuCanvas != null) mainMenuCanvas.SetActive(false);
        if (levelCompleteCanvas != null) levelCompleteCanvas.SetActive(true);
            
        // 2. Set Text Judul
        if (resultText != null)
        {
            resultText.text = isPassed ? "LEVEL COMPLETED" : "LEVEL FAILED";
            resultText.color = isPassed ? Color.green : Color.red;
        }

        // 3. Set Text Feedback (PERBAIKAN UTAMA DI SINI)
        if (feedbackText != null)
        {
            // Debugging: Cek di Console apakah pesannya masuk
            Debug.Log($"Menampilkan Feedback di UI: {feedbackMsg}"); 
            feedbackText.text = feedbackMsg;
        }
        else
        {
            // Peringatan jika Anda lupa Drag & Drop di Inspector
            Debug.LogError("ERROR: 'feedbackText' belum di-assign di Inspector VRLevelManager! Pesan tidak akan muncul.");
        }

        // (Bagian Confidence Score SUDAH DIHAPUS dari sini)

        // 4. Atur Tombol
        if (isPassed)
        {
            if(btnNextLevel) btnNextLevel.SetActive(true);
            if(btnRetry) btnRetry.SetActive(false); 
        }
        else
        {
            if(btnNextLevel) btnNextLevel.SetActive(false);
            if(btnRetry) btnRetry.SetActive(true);
        }
    }

    public void RestartCurrentLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        if (currentScene == "VR Basic")
        {
            isRestartingLevel1 = true;
        }
        SceneManager.LoadScene(currentScene);
    }

    public void LoadNextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("Sudah tamat!");
            if(resultText) resultText.text = "ALL LEVELS COMPLETED!";
            if(btnNextLevel) btnNextLevel.SetActive(false);
        }
    }
}