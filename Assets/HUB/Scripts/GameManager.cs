using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {

        [Header("Badge States")]
        [SerializeField] bool archeryBadge = false;
        [SerializeField] bool destructionBadge = false;
        [SerializeField] bool rockClimbingBadge = false;

        [Header("Game Highscores")]
        [SerializeField] int[] archeryScore = new int[5];
        [SerializeField] string[] archeryNames = new string[5];
        [SerializeField] int[] destructionScore = new int[5];
        [SerializeField] string[] destructionNames = new string[5];
        [SerializeField] int[] rockClimbingScore = new int[5];
        [SerializeField] string[] rockClimbingNames = new string[5];

        public enum Games { Archery, Destruction, RockClimbing }


        // Singleton implementation
        private static GameManager instance = null;
        public static GameManager Instance { get { return instance; } }


        void Awake()
        {
            //Set Singleton Reference
            if (instance != null)
            {
                if (instance != this)
                {
                    Destroy(this);
                }
            }
            else
            {
                instance = this;
            }

            DontDestroyOnLoad(this.gameObject);

            //Establish Leaderboards
            /*for (int i = 0; i < archeryScore.Length; i++)
            {
                archeryScore[i] = new Scores();
            }
            for (int i = 0; i < destructionScore.Length; i++)
            {
                destructionScore[i] = new Scores();
            }
            for (int i = 0; i < rockClimbingScore.Length; i++)
            {
                rockClimbingScore[i] = new Scores();
            }*/

            //StartCoroutine(TestScores());
        }


        //used to test leaderboards
        IEnumerator TestScores()
        {
            yield return new WaitForSeconds(2f);

            for (int i = 0; i < archeryScore.Length; i++)
            {
                Debug.Log("Archery Leaderboard " + i + "Name: " + archeryNames[i] + "; Score " + archeryScore[i]);
            }
            /*
            for (int i = 0; i < destructionScore.Length; i++)
            {
                Debug.Log("Destruction Score " + destructionScore[i].GetScore());
                Debug.Log("Destruction Name " + destructionScore[i].GetName());
            }
            for (int i = 0; i < rockClimbingScore.Length; i++)
            {
                Debug.Log("rockClimbing Score " + rockClimbingScore[i].GetScore());
                Debug.Log("rockClimbing Name " + rockClimbingScore[i].GetName());
            }
            */

        }

        public void SetBadgeState(Games badge, bool badgeState)
        {
            switch (badge)
            {
                case Games.Archery:
                    archeryBadge = badgeState;
                    break;
                case Games.Destruction:
                    destructionBadge = badgeState;
                    break;
                case Games.RockClimbing:
                    rockClimbingBadge = badgeState;
                    break;
            }
        }

        public bool GetBadgeState(Games game)
        {
            switch (game)
            {
                case Games.Archery:
                    return archeryBadge;

                case Games.Destruction:
                    return destructionBadge;

                case Games.RockClimbing:
                    return rockClimbingBadge;

            }
            return false;
        }

        public void SetHighScore(Games game, int score, string name)
        {
            int scoreToUpdate = -1;
            bool updateScore = false;

            switch (game)
            {
                case Games.Archery:
                    for (int i = 0; i < archeryScore.Length; i++)
                    {
                        if (archeryScore[i] == score) { break; }
                        if (archeryScore[i] < score)
                        {
                            scoreToUpdate = i;
                            updateScore = true;
                            break;
                        }
                    }
                    if (updateScore == true)
                    {
                        for (int x = 4; x >= 0; x--)
                        {
                            if (x != scoreToUpdate)
                            {
                                archeryScore[x] = archeryScore[x - 1];
                                archeryNames[x] = archeryNames[x - 1];
                            }
                            else
                            {
                                archeryScore[x] = score;
                                archeryNames[x] = name;
                                break;
                            }
                        }
                    }

                    break;

                case Games.Destruction:
                    for (int i = 0; i < destructionScore.Length; i++)
                    {
                        if (destructionScore[i] == score) { break; }
                        if (destructionScore[i] < score)
                        {
                            scoreToUpdate = i;
                            updateScore = true;
                            break;
                        }
                    }
                    if (updateScore == true)
                    {
                        for (int x = 4; x >= 0; x--)
                        {
                            if (x != scoreToUpdate)
                            {
                                destructionScore[x] = destructionScore[x - 1];
                                destructionNames[x] = destructionNames[x - 1];
                            }
                            else
                            {
                                destructionScore[x] = score;
                                destructionNames[x] = name;
                                break;
                            }
                        }
                    }
                    break;
                case Games.RockClimbing:
                    for (int i = 0; i < rockClimbingScore.Length; i++)
                    {
                        if (rockClimbingScore[i] == score) { break; }
                        if (rockClimbingScore[i] < score)
                        {
                            scoreToUpdate = i;
                            updateScore = true;
                            break;
                        }
                    }
                    if (updateScore == true)
                    {
                        for (int x = 4; x >= 0; x--)
                        {
                            if (x != scoreToUpdate)
                            {
                                rockClimbingScore[x] = rockClimbingScore[x - 1];
                                rockClimbingNames[x] = rockClimbingNames[x - 1];
                            }
                            else
                            {
                                rockClimbingScore[x] = score;
                                rockClimbingNames[x] = name;
                                break;
                            }
                        }
                    }
                    break;

            }
        }

        public int[] GetHighScoresScores(Games game)
        {
            switch (game)
            {
                case Games.Archery:
                    return archeryScore;
                case Games.Destruction:
                    return destructionScore;
                case Games.RockClimbing:
                    return rockClimbingScore;
            }
            return null;

        }
        public string[] GetHighScoresNames(Games game)
        {
            switch (game)
            {
                case Games.Archery:
                    return archeryNames;
                case Games.Destruction:
                    return destructionNames;
                case Games.RockClimbing:
                    return rockClimbingNames;
            }
            return null;
        }
    }

}