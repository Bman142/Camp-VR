using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ArcheryCountdownTimer : MonoBehaviour
    {
        public TextMeshProUGUI timerTextDisplay;
        public int timerSecondsLeft = 90;
        public bool timerTakingAway = false;

        public HoverButton hoverButton;

        public bool timerStarted = false;

        public float flickerTime = 0.1f;

        public bool spawn = false;

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
            Debug.Log("addlistener onButtonDown");
        }


        public void OnButtonDown(Hand hand)
        {
            if ( timerStarted == false )
            {
                StartCoroutine(TimerTake());
                timerStarted = true;
               
                //Debug.Log("Starting Coroutine timertake");
            }
        }



       public IEnumerator TimerTake()
        {
            spawn = true;
            while ( timerSecondsLeft > 0 )
            {
                yield return new WaitForSeconds(1f);
                timerSecondsLeft--;
                if ( timerSecondsLeft < 10 )
                {
                    timerTextDisplay.GetComponent<TextMeshProUGUI>().text = "0" + timerSecondsLeft;
                }
                else
                {
                    timerTextDisplay.GetComponent<TextMeshProUGUI>().text = "" + timerSecondsLeft;
                }
            }

            spawn = false;
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(false);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(true);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(false);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(true);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(false);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(true);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(false);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(true);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(false);
            yield return new WaitForSeconds(flickerTime);
            timerTextDisplay.gameObject.SetActive(true);


        }
    }
}

