
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;

    
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text HighScoreText;
   
    private const string HIGHSCORE_KEY = "HighScoreKey";

    private int score=0;


    private void Awake()
    {
        if (instance == null)
        
            { instance = this; }
        
    }
    private void Start()
    {
        scoreText.text = $"Score : {score}";
        HighScoreText.text = $"High Score : {GetHighScore()}";
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = $"Score : {score}";
        if (score> GetHighScore())
        {
            SaveHighScore(score);
            HighScoreText.text = $"High Score : {GetHighScore()}";
        }
    }

    private static void SaveHighScore(int highScore)
    {
        PlayerPrefs.SetInt(HIGHSCORE_KEY, highScore);
        PlayerPrefs.Save();
    }
    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(HIGHSCORE_KEY, 0);
    }
}
