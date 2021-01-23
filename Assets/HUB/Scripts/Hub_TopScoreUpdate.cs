using UnityEngine;
using TMPro;
using Manager;

public class Hub_TopScoreUpdate : MonoBehaviour
{
    public bool debug;

    [SerializeField] GameManager.Games game;
    [SerializeField] GameManager manager;
    [SerializeField] TextMeshProUGUI[] scores = new TextMeshProUGUI[5];
    [SerializeField] TextMeshProUGUI[] names = new TextMeshProUGUI[5];

    void Start()
    {
        manager = GameManager.Instance;

    }

    public void UpdateScores()
    {
        /*
         foreach (Scores scores in scoresIn)
         {
             Debug.Log(scores.name);
             Debug.Log(scores.score.ToString());
         }
         */
        for (int i = 0; i <= 4; i++)
        {
            names[i].text = manager.GetHighScoresNames(game)[i];
            //if (debug) { Debug.Log("Name " + i.ToString() + ": " + scoresIn[i].GetName()); }
            scores[i].text = manager.GetHighScoresScores(game)[i].ToString();
            //if (debug) { Debug.Log("Score " + i.ToString() + ": " + scoresIn[i].GetScore().ToString()); }
        }

    }

    private void Update()
    {
        //TODO make event/method for updating scores for performance
        UpdateScores();
    }


}