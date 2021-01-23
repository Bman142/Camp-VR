using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    [SerializeField] int currentScore = 0;
    [SerializeField] int highScore;

    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] TextMeshProUGUI currentScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
    }

    public void AddScore(int score)
    {
        currentScore += score;

       if (currentScore > highScore)
        {
            highScore = currentScore;
        }
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetInt("highScore", highScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = "High Score: " + highScore.ToString();
        currentScoreText.text = "Score: " + currentScore.ToString();
    }
}
