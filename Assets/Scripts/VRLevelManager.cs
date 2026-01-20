using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRLevelManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject mainMenuCanvas;       // Canvas pilih level (Hanya diisi di Level 1)
    public GameObject levelCompleteCanvas;  // Canvas Next/Restart

    // Static variable untuk mengingat status restart di Level 1
    // Agar saat Level 1 di-restart, dia tidak kembali menampilkan Menu Pilih Level
    public static bool isRestartingLevel1 = false;

    void Start()
    {
        // Cek apakah kita sedang di Scene Level 1 (VR Basic)
        if (SceneManager.GetActiveScene().name == "VR Basic")
        {
            if (isRestartingLevel1)
            {
                // Jika ini adalah hasil restart, sembunyikan menu awal, langsung main
                if (mainMenuCanvas != null) mainMenuCanvas.SetActive(false);
                
                // Reset status agar jika user quit dan masuk lagi, menu muncul lagi
                isRestartingLevel1 = false; 
            }
            else
            {
                // Jika baru pertama buka game, munculkan menu
                if (mainMenuCanvas != null) mainMenuCanvas.SetActive(true);
            }
        }
        else
        {
            // Di Level 2 dan 3, pastikan MainMenu tidak ada/mati
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

    // --- FUNGSI SAAT TASK SELESAI ---
    
    // Panggil fungsi ini dari script Task/Game Logic Anda ketika semua tugas beres
    public void ShowLevelCompleteUI()
    {
        if (levelCompleteCanvas != null)
        {
            levelCompleteCanvas.SetActive(true);
            
            // Posisikan canvas di depan kamera player (opsional, biar user gak perlu noleh)
            // Transform head = Camera.main.transform;
            // levelCompleteCanvas.transform.position = head.position + (head.forward * 2f);
            // levelCompleteCanvas.transform.LookAt(new Vector3(head.position.x, levelCompleteCanvas.transform.position.y, head.position.z));
            // levelCompleteCanvas.transform.Rotate(0, 180, 0);
        }
    }

    // --- FUNGSI UNTUK TOMBOL NEXT & RESTART ---

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
            // Opsional: Kembali ke Main Menu
            // SceneManager.LoadScene("VR Basic");
        }
    }
}