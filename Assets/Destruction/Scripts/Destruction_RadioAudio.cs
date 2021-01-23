using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

public class Destruction_RadioAudio : MonoBehaviour
{
    public AudioClip[] radioSongs;
    AudioSource source;
    Destruction_TunerChanger tC;
    Destruction_RadioVolume rVolume;
    Destruction_RadioMute muted;
    public int songID;

    [SerializeField] bool isPlaying;
    public bool togChange;
    [SerializeField] float timer = 1;

    private void Awake()
    {
        source = this.gameObject.GetComponent<AudioSource>();
        tC = GetComponentInChildren<Destruction_TunerChanger>();
        rVolume = GetComponentInChildren<Destruction_RadioVolume>();
        muted = GetComponentInChildren<Destruction_RadioMute>();
    }

    private void Start()
    {
        isPlaying = true;
        togChange = true;
    }

    void Update()
    {
        songID = tC.SongID;

        if (isPlaying == true && togChange == true)
        {
            source.PlayOneShot(radioSongs[songID]);
            togChange = false;
            isPlaying = false;
        }

        if (isPlaying == false && togChange == true)
        {
            source = this.gameObject.GetComponent<AudioSource>();
            source.Stop();
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timer);
        isPlaying = true;
        Debug.Log("Wait for " + timer + " seconds");
    }
}
