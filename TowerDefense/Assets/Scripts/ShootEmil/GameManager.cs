using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuPanel;
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private TMP_Text scoreText;
    private void Awake()
    {
        MainMenuPanel.SetActive(true);
        GameOverPanel.SetActive(false);
        Time.timeScale = 0f;
    }
    private void Start()
    {
        scoreText.text = "HighScore: " + SaveSystem.instance.GetHighScore().ToString();
    }
    public void PlayGame()
    {
        MainMenuPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("ShootEmil");
  
    }
}
