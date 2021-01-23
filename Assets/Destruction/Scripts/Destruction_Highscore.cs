using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manager;

public class Destruction_Highscore : MonoBehaviour
{

    [SerializeField] GameManager manager;

    public Destruction_WoodScore score;
    public Destruction_CountdownController timer;

    public int scoreForBadge = 50;

    
    void Start()
    {
        manager = GameManager.Instance;
    }

    void Update()
    {
        if (score.currentScore >= scoreForBadge)
        {
            StartCoroutine(ReachBadge());
        }

        if (timer.countdownTime <= 0)
        {
            StartCoroutine(SetHighScore());
        }

    }

    IEnumerator ReachBadge()
    {
        yield return new WaitForSeconds(1f);
        manager.SetBadgeState(GameManager.Games.Destruction, true);
    }
    IEnumerator SetHighScore()
    {
        yield return new WaitForSeconds(1f);
        manager.SetHighScore(GameManager.Games.Destruction, score.currentScore, "Player");
    }
    
}
