using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destruction_CountdownController : MonoBehaviour
{

    public int countdownTime;
    public TMP_Text countdownDisplay;
    public TMP_Text timeRemainingText;
    public Destruction_WoodDumped woodDumped;
    [Range(0.0f, 2.0f)]
    public float flickerTime;

    public static bool gameStart = false;

    bool gameHasStarted = false;

    GameObject controller;
    Destruction_SFX soundEffects;

    void Awake()
    {
        controller = GameObject.Find("Controller");
        soundEffects = controller.GetComponent<Destruction_SFX>();
    }

    private void Update()
    {
        if (gameHasStarted == false)
        {
            if (gameStart == true)
            {
                StartCoroutine(CountdownToEnd());
                timeRemainingText.gameObject.SetActive(true);
                gameHasStarted = true;
            }
        }
    }

    IEnumerator CountdownToEnd()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "TIME'S UP";

        woodDumped.scoreIncrease = 0;

        //Flash when done (I know theres a forloop I could do but I didnt
        soundEffects.PlayTimesUp();
        yield return new WaitForSeconds(flickerTime);
        countdownDisplay.gameObject.SetActive(false);
        yield return new WaitForSeconds(flickerTime);
        countdownDisplay.gameObject.SetActive(true);
        soundEffects.PlayTimesUp();
        yield return new WaitForSeconds(flickerTime);
        countdownDisplay.gameObject.SetActive(false);
        yield return new WaitForSeconds(flickerTime);
        countdownDisplay.gameObject.SetActive(true);
        soundEffects.PlayTimesUp();
        yield return new WaitForSeconds(flickerTime);
        countdownDisplay.gameObject.SetActive(false);
        yield return new WaitForSeconds(flickerTime);
        countdownDisplay.gameObject.SetActive(true);
        soundEffects.PlayTimesUp();

    }

}
