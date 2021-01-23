using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction_SFX : MonoBehaviour
{
    public AudioSource CollectWood;
    public AudioSource TimesUp;
    public AudioSource ChopWood;

    public AudioSource songOne;
    public AudioSource songTwo;
    //public AudioSource name;

    public void PlayCollectWood()
    {
        CollectWood.Play();
    }

    public void PlayTimesUp()
    {
        TimesUp.Play();
    }

    public void PlayChopWood()
    {
        ChopWood.Play();
    }

    public void PlaySongOne()
    {
        songOne.Play();
    }

    public void PlaySongTwo()
    {
        songTwo.Play();
    }

    //public void PlaySoundName()
    //{
    //    SoundName.Play();
    //}

}
