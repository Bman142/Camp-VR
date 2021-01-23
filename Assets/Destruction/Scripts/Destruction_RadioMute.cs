using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Destruction_RadioMute : MonoBehaviour
{
    CircularDrive cD;
    Destruction_RadioVolume rV;
    AudioSource radioVolume;

    public bool isMuted;

    private void Awake()
    {
        cD = this.gameObject.GetComponent<CircularDrive>();
        rV = GetComponentInParent<Destruction_RadioVolume>();
        radioVolume = GetComponentInParent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isMuted = false;
        cD.maxAngle = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMuted == true)
        {
            radioVolume.volume = 0f;
        }
        else
        {
            radioVolume.volume = 1f;
        }
    }

    public void Muted()
    {
        isMuted = true;
    }

    public void UnMuted()
    {
        isMuted = false;
    }
}
