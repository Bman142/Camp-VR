using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destruction_WoodScore : MonoBehaviour
{

    public TMP_Text scoreText;
    public int currentScore = 0;

    void Update()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
    }
}
