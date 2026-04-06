using UnityEngine;
using UnityEngine.SceneManagement;
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
    public TextMeshProUGUI confidenceText;   // text probability
    public TextMeshProUGUI feedbackText;     // text feedback

    public static bool isRestartingLevel1 = false;

    private void Awake()
    {
        ResolveUIReferences();
    }

    void Start()
    {
        ResolveUIReferences();

        if (SceneManager.GetActiveScene().name == "VR Basic")
        {
            if (isRestartingLevel1)
            {
                if (mainMenuCanvas != null)
                    mainMenuCanvas.SetActive(false);

                isRestartingLevel1 = false;
            }
            else
            {
                if (mainMenuCanvas != null)
                    mainMenuCanvas.SetActive(true);
            }
        }
        else
        {
            if (mainMenuCanvas != null)
                mainMenuCanvas.SetActive(false);
        }

        if (levelCompleteCanvas != null)
            levelCompleteCanvas.SetActive(false);

        if (confidenceText != null)
            confidenceText.text = "";

        if (feedbackText != null)
            feedbackText.text = "";
    }

    private void ResolveUIReferences()
    {
        if (levelCompleteCanvas == null)
        {
            Debug.LogWarning("levelCompleteCanvas belum di-assign.");
            return;
        }

        Transform confTf = levelCompleteCanvas.transform.Find("ConfidenceText");
        if (confTf != null)
        {
            confidenceText = confTf.GetComponent<TextMeshProUGUI>();
        }

        Transform feedTf = levelCompleteCanvas.transform.Find("FeedbackText");
        if (feedTf != null)
        {
            feedbackText = feedTf.GetComponent<TextMeshProUGUI>();
        }

        Debug.Log(
            $"ResolveUIReferences => " +
            $"confidenceText={(confidenceText != null ? confidenceText.name : "NULL")}, " +
            $"feedbackText={(feedbackText != null ? feedbackText.name : "NULL")}"
        );
    }

    public void SelectLevel(string levelName)
    {
        if (levelName == "VR Basic")
        {
            if (mainMenuCanvas != null)
                mainMenuCanvas.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(levelName);
        }
    }

    public void ShowLevelCompleteUI(bool isPassed, double confidence, string feedbackMsg)
    {
        ResolveUIReferences();

        if (mainMenuCanvas != null)
            mainMenuCanvas.SetActive(false);

        if (levelCompleteCanvas != null)
            levelCompleteCanvas.SetActive(true);

        Color resultColor = isPassed ? Color.green : Color.red;

        // Probability
        if (confidenceText != null)
        {
            confidenceText.gameObject.SetActive(true);
            confidenceText.text = $"Probabilitas Lulus: {confidence * 100:F1}%";
            confidenceText.color = resultColor;
            confidenceText.fontSize = 24;
            confidenceText.ForceMeshUpdate();

            Debug.Log($"SET confidenceText => {confidenceText.text} | object={confidenceText.name}");
        }
        else
        {
            Debug.LogWarning("confidenceText NULL saat ShowLevelCompleteUI.");
        }

        // Feedback
        if (feedbackText != null)
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = feedbackMsg;
            feedbackText.color = resultColor;
            feedbackText.ForceMeshUpdate();

            Debug.Log($"SET feedbackText => {feedbackText.text} | object={feedbackText.name}");
        }
        else
        {
            Debug.LogWarning("feedbackText NULL saat ShowLevelCompleteUI.");
        }

        Debug.Log($"UI RESULT => Passed={isPassed}, Confidence={confidence * 100:F1}%, Feedback={feedbackMsg}");

        // Buttons
        if (isPassed)
        {
            if (btnNextLevel != null) btnNextLevel.SetActive(true);
            if (btnRetry != null) btnRetry.SetActive(false);
        }
        else
        {
            if (btnNextLevel != null) btnNextLevel.SetActive(false);
            if (btnRetry != null) btnRetry.SetActive(true);
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

            if (btnNextLevel != null)
                btnNextLevel.SetActive(false);

            if (confidenceText != null)
            {
                confidenceText.text = "Semua level selesai!";
                confidenceText.color = Color.green;
            }

            if (feedbackText != null)
            {
                feedbackText.text = "";
            }
        }
    }
}