using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using VRKeys; // [PENTING] Namespace untuk mengakses script aset VRKeys

public class AuthManager : MonoBehaviour
{
    [Header("VR Keys Reference")]
    // Tarik object 'VRKeys' (yang ada script Keyboard-nya) dari Hierarchy ke slot ini
    public Keyboard vrKeyboard; 

    [Header("UI Panels")]
    public GameObject loginPanel;
    public GameObject registerPanel;

    [Header("Login Components")]
    public TMP_InputField loginInput;
    public TextMeshProUGUI loginFeedback;

    [Header("Register Components")]
    public TMP_InputField registerInput;
    public TextMeshProUGUI registerFeedback;

    [Header("Scene Settings")]
    public string nextSceneName = "VR Basic";

    // Variabel untuk melacak input field mana yang sedang diedit
    private TMP_InputField currentActiveInput;

// Ubah dari 'void Start' menjadi 'IEnumerator Start'
    IEnumerator Start() 
    {
        // 1. Pastikan VRKeys NYALA dulu agar dia bisa membangun tombol-tombolnya
        if (vrKeyboard != null)
        {
            vrKeyboard.gameObject.SetActive(true); 
        }

        // 2. TUNGGU sampai VRKeys selesai inisialisasi (membuat tombol QWERTY)
        // (Kita tunggu sampai variabel 'initialized' di script Keyboard bernilai true)
        if (vrKeyboard != null)
        {
            // Tunggu maksimal 3 detik (safety timeout) atau sampai initialized true
            float timer = 0;
            while (!vrKeyboard.initialized && timer < 3f)
            {
                timer += Time.deltaTime;
                yield return null; // Tunggu frame berikutnya
            }
        }

        // 3. Setup Input Field Anda (agar keyboard HP tidak muncul)
        SetupInputField(loginInput);
        SetupInputField(registerInput);

        // 4. BARU SEKARANG matikan keyboardnya (Sembunyikan)
        if (vrKeyboard != null)
        {
            vrKeyboard.Disable();
            vrKeyboard.gameObject.SetActive(false);
        }

        // 5. Masuk ke tampilan Login
        SwitchToLogin();
    }

    // Update tidak lagi dibutuhkan untuk keyboard logic, 
    // karena kita menggunakan Event System dari VRKeys
    void Update() { }

    // ==============================
    // INPUT FIELD SETUP
    // ==============================
    void SetupInputField(TMP_InputField input)
    {
        if (input == null) return;

        // Kita set ReadOnly agar keyboard Android native tidak muncul
        // Tapi kita tetap bisa mengubah text-nya lewat script
        input.readOnly = true; 
        
        // Pastikan input field tidak terpilih secara navigasi (opsional)
        input.navigation = new UnityEngine.UI.Navigation { mode = UnityEngine.UI.Navigation.Mode.None };
    }

    // ==============================
    // KEYBOARD CONTROL (LOGIKA UTAMA)
    // ==============================
    
    // Dipanggil via Event Trigger di InputText_Login
    public void OpenKeyboardForLogin()
    {
        currentActiveInput = loginInput;
        ActivateVRKeyboard();
    }

    // Dipanggil via Event Trigger di InputText_Register
    public void OpenKeyboardForRegister()
    {
        currentActiveInput = registerInput;
        ActivateVRKeyboard();
    }

    private void ActivateVRKeyboard()
    {
        if (vrKeyboard == null)
        {
            Debug.LogError("VRKeys belum dimasukkan ke Inspector AuthManager!");
            return;
        }

        if (currentActiveInput == null) return;

        // 1. Munculkan Object Keyboard
        vrKeyboard.gameObject.SetActive(true);
        vrKeyboard.Enable();

        // 2. Sinkronisasi Teks: Ambil teks yang sudah ada di UI, masukkan ke Keyboard VR
        vrKeyboard.SetText(currentActiveInput.text);

        // 3. WIRING EVENTS: Hubungkan event VRKeys ke fungsi kita
        // Hapus dulu listener lama agar tidak double
        vrKeyboard.OnUpdate.RemoveAllListeners();
        vrKeyboard.OnSubmit.RemoveAllListeners();
        vrKeyboard.OnCancel.RemoveAllListeners();

        // Pasang listener baru
        vrKeyboard.OnUpdate.AddListener(HandleKeyboardUpdate); // Saat ngetik
        vrKeyboard.OnSubmit.AddListener(HandleKeyboardSubmit); // Saat Enter
        vrKeyboard.OnCancel.AddListener(HandleKeyboardCancel); // Saat Cancel
    }

    // ==============================
    // EVENT HANDLERS (JEMBATAN DATA)
    // ==============================

    // Fungsi ini dipanggil otomatis setiap kali tombol huruf ditekan di VRKeys
    public void HandleKeyboardUpdate(string text)
    {
        if (currentActiveInput != null)
        {
            // Copy teks dari VRKeys langsung ke UI Input Field Anda
            currentActiveInput.text = text;
        }
    }

    // Fungsi ini dipanggil saat tombol ENTER ditekan
    public void HandleKeyboardSubmit(string text)
    {
        // Pastikan update terakhir masuk
        HandleKeyboardUpdate(text);

        // Sembunyikan keyboard
        CloseKeyboard();

        // Opsional: Langsung trigger tombol login/register jika Enter ditekan
        // if (currentActiveInput == loginInput) OnLoginClicked();
    }

    // Fungsi ini dipanggil saat tombol CANCEL ditekan
    public void HandleKeyboardCancel()
    {
        CloseKeyboard();
    }

    private void CloseKeyboard()
    {
        if (vrKeyboard != null)
        {
            vrKeyboard.Disable();
            vrKeyboard.gameObject.SetActive(false);
        }
        currentActiveInput = null;
    }

    // ==============================
    // UI NAVIGATION
    // ==============================
    public void SwitchToRegister()
    {
        CloseKeyboard(); // Tutup keyboard jika masih terbuka
        loginPanel.SetActive(false);
        registerPanel.SetActive(true);

        registerInput.text = "";
        registerFeedback.text = "";
    }

    public void SwitchToLogin()
    {
        CloseKeyboard(); // Tutup keyboard jika masih terbuka
        registerPanel.SetActive(false);
        loginPanel.SetActive(true);

        loginInput.text = "";
        loginFeedback.text = "";
    }

    // ==============================
    // REGISTER LOGIC (TIDAK BERUBAH)
    // ==============================
    public void OnRegisterClicked()
    {
        // Trim() membersihkan spasi di awal/akhir input
        string username = registerInput.text.Trim();

        if (string.IsNullOrEmpty(username))
        {
            ShowFeedback(registerFeedback, "Nama tidak boleh kosong!", Color.red);
            return;
        }

        if (PlayerPrefs.HasKey("ACCOUNT_" + username))
        {
            ShowFeedback(registerFeedback, "Nama sudah terdaftar!", Color.red);
        }
        else
        {
            PlayerPrefs.SetInt("ACCOUNT_" + username, 1);
            PlayerPrefs.Save();

            ShowFeedback(registerFeedback, "Registrasi Berhasil!", Color.green);
            StartCoroutine(DelaySwitchToLogin());
        }
    }

    // ==============================
    // LOGIN LOGIC (TIDAK BERUBAH)
    // ==============================
    public void OnLoginClicked()
    {
        string username = loginInput.text.Trim();

        if (string.IsNullOrEmpty(username))
        {
            ShowFeedback(loginFeedback, "Masukkan nama Anda.", Color.yellow);
            return;
        }

        if (PlayerPrefs.HasKey("ACCOUNT_" + username))
        {
            ShowFeedback(loginFeedback, "Login Sukses!", Color.green);
            PlayerPrefs.SetString("CURRENT_USER", username);
            PlayerPrefs.Save();
            StartCoroutine(LoadNextScene());
        }
        else
        {
            ShowFeedback(loginFeedback, "Nama belum terdaftar.", Color.red);
        }
    }

    // ==============================
    // HELPERS
    // ==============================
    void ShowFeedback(TextMeshProUGUI text, string message, Color color)
    {
        if (text != null)
        {
            text.text = message;
            text.color = color;
            text.gameObject.SetActive(true);
        }
    }

    IEnumerator DelaySwitchToLogin()
    {
        yield return new WaitForSeconds(1.5f);
        SwitchToLogin();
        // Opsional: pindahkan nama yang baru diregister ke field login
        loginInput.text = registerInput.text;
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(nextSceneName);
    }
}