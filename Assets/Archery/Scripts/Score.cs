using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    int currentScore = 0;

    void Update()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
    }

    public int GetScore()
    {
        return currentScore;
    }
}