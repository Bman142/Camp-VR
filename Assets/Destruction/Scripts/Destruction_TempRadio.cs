using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class Destruction_TempRadio : MonoBehaviour
    {

        GameObject controller;
        Destruction_SFX soundEffects;
        int song = 0;
        bool playing;
        bool on;

        //For Buttons
        bool toggled;
        bool tuned;

        public GameObject onOffButton;
        public GameObject tuneButton;

        AudioSource playingSong;


        void Awake()
        {
            controller = GameObject.Find("Controller");
            soundEffects = controller.GetComponent<Destruction_SFX>();
            on = true;
            playing = true;
            playingSong = soundEffects.songOne;
            playingSong.Play();
        }

        private void Update()
        {
            if (playing == false)
            {
                playingSong.Play();
                playing = true;
            }

            if (song == 0)
            {
                playingSong = soundEffects.songOne;
            }

            if (song == 1)
            {
                playingSong = soundEffects.songTwo;
            }

        }

        public void OnToggleDown(Hand fromHand)
        {
            if (toggled == false)
            {
                if (on == true)
                {
                    playingSong.Stop();
                    TurnOff();
                    on = false;
                }
                else
                {
                    playingSong.Play();
                    on = true;
                }
                toggled = true;
            }
        }

        public void OnToggleUp(Hand fromHand)
        {
            toggled = false;
        }

        public void OnTuneDown(Hand fromHand)
        {
            if (tuned == false)
            {
                playingSong.Stop();
                TurnOff();
                if (song == 0)
                {
                    song = 1;
                }
                else
                {
                    song = 0;
                }
                playing = false;
                tuned = true;
            }
        }

        public void OnTuneUp(Hand fromHand)
        {
            tuned = false;
        }

        void TurnOff()
        {
            soundEffects.songOne.Stop();
            soundEffects.songTwo.Stop();
        }

    }

}