using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; // WAJIB: Agar bisa pakai TextMeshProUGUI

public class VRLevelManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject mainMenuCanvas;       // Canvas pilih level (Hanya diisi di Level 1)
    public GameObject levelCompleteCanvas;  // Canvas utama untuk Win/Lose

    [Header("AI Result Elements")]
    public GameObject btnNextLevel;         // Tombol Lanjut (Drag dari Hierarchy)
    public GameObject btnRetry;             // Tombol Ulang (Drag dari Hierarchy)
    public TextMeshProUGUI resultText;      // Text status (Drag dari Hierarchy)

    // Static variable untuk mengingat status restart di Level 1
    // Agar saat Level 1 di-restart, dia tidak kembali menampilkan Menu Pilih Level
    public static bool isRestartingLevel1 = false;

    void Start()
    {
        // --- LOGIKA MENU LEVEL 1 (SAMA SEPERTI SEBELUMNYA) ---
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

        // Pastikan menu "Win/Selesai" mati di awal
        if (levelCompleteCanvas != null) levelCompleteCanvas.SetActive(false);
    }

    // --- FUNGSI UNTUK TOMBOL MENU AWAL ---

    public void SelectLevel(string levelName)
    {
        // Jika user pilih Level 1, kita tidak perlu load scene baru (karena sudah di sana)
        // Cukup sembunyikan UI Menu
        if (levelName == "VR Basic")
        {
            if (mainMenuCanvas != null) mainMenuCanvas.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(levelName);
        }
    }

    // --- FUNGSI SAAT TASK SELESAI (DIPANGGIL GLOBALROOMMANAGER) ---
    
    // Perubahan: Sekarang menerima parameter bool dari AI
    public void ShowLevelCompleteUI(bool userPassed)
    {
        if (levelCompleteCanvas != null)
        {
            levelCompleteCanvas.SetActive(true);
            
            // LOGIKA UI BERDASARKAN HASIL AI
            if (userPassed)
            {
                // LULUS: Boleh lanjut, tidak perlu ulang
                if(btnNextLevel) btnNextLevel.SetActive(true);
                if(btnRetry) btnRetry.SetActive(false); // Atau set true jika user boleh mengulang sukarela
                
                if(resultText) resultText.text = "LEVEL COMPLETED!\n<color=green>AI Status: PASSED</color>";
            }
            else
            {
                // GAGAL: Tidak boleh lanjut, harus ulang
                if(btnNextLevel) btnNextLevel.SetActive(false);
                if(btnRetry) btnRetry.SetActive(true);
                
                if(resultText) resultText.text = "LEVEL FAILED.\n<color=red>AI Status: RETRY REQUIRED</color>";
            }
        }
    }

    // --- FUNGSI UNTUK TOMBOL DI UNITY INSPECTOR ---

    // Hubungkan ini ke Button Retry -> OnClick()
    public void RestartCurrentLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        // Khusus jika kita me-restart Level 1, set flag static jadi true
        if (currentScene == "VR Basic")
        {
            isRestartingLevel1 = true;
        }

        SceneManager.LoadScene(currentScene);
    }

    // Hubungkan ini ke Button Next Level -> OnClick()
    public void LoadNextLevel()
    {
        // Ambil index scene saat ini + 1
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // Cek apakah scene selanjutnya ada di Build Settings
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("Sudah tamat! (Ini level terakhir)");
            // Opsional: Tampilkan teks tamat atau kembali ke menu
            if(resultText) resultText.text = "ALL LEVELS COMPLETED!";
        }
    }
}