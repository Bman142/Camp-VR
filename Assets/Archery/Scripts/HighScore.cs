using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manager;
using Valve.VR.InteractionSystem.Sample;

public class HighScore : MonoBehaviour
{
    [SerializeField] GameManager gameManager = null;
    [SerializeField] ArcheryCountdownTimer timer;
    [SerializeField] Score score;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        bool scoreSent = false;
        if(timer.timerSecondsLeft == 0 && !scoreSent)
        {
            int currentScore = score.GetScore();
            gameManager.SetHighScore(GameManager.Games.Archery, currentScore, "Archery");
            scoreSent = true;
            if (currentScore >= 20)
            {
                gameManager.SetBadgeState(GameManager.Games.Archery, true);
            }
        }
    }
}
