using UnityEngine;
using TMPro; // Wajib untuk UI TextMeshPro
using UnityEngine.SceneManagement; // Wajib untuk pindah scene
using System.Collections; // Wajib untuk Coroutine (Jeda waktu)

public class SimpleLogin : MonoBehaviour
{
    [Header("UI References")]
    public TMP_InputField nameInput;
    public TextMeshProUGUI feedbackText;

    [Header("Setting Scene")]
    public string vrRoomSceneName = "NamaSceneVRKamu"; // GANTI INI dengan nama scene task

    void Start()
    {
        // Pastikan teks feedback kosong/mati saat mulai
        if(feedbackText) feedbackText.text = ""; 
    }

    // Fungsi ini akan dipanggil tombol
    public void OnLoginClicked()
    {
        // 1. Cek apakah nama kosong? (Opsional)
        if (string.IsNullOrEmpty(nameInput.text))
        {
            if(feedbackText) 
            {
                feedbackText.text = "Mohon isi nama dulu!";
                feedbackText.color = Color.red;
            }
            return; 
        }

        // 2. Jika ada isinya, jalankan proses Login
        StartCoroutine(ProcessLoginSequence());
    }

    IEnumerator ProcessLoginSequence()
    {
        // Tampilkan feedback positif
        if(feedbackText)
        {
            feedbackText.color = Color.green;
            feedbackText.text = "Login Berhasil!";
            // Jika objectnya dimatikan, nyalakan dulu:
            feedbackText.gameObject.SetActive(true); 
        }

        Debug.Log("User: " + nameInput.text + " berhasil login.");

        // 3. TUNGGU SEBENTAR (Misal 2 detik) supaya user sempat baca tulisan "Login Berhasil"
        yield return new WaitForSeconds(2.0f);

        // 4. Pindah Scene
        SceneManager.LoadScene(vrRoomSceneName);
    }
}