using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Destruction_TunerChanger : MonoBehaviour
{
    private Destruction_RadioAudio rA;
    private CircularDrive cD;

    public int SongID = 0;

    private float currentID;

    // Start is called before the first frame update
    void Start()
    {
        rA = GetComponentInParent<Destruction_RadioAudio>();
        cD = this.gameObject.GetComponent<CircularDrive>();

        cD.maxAngle = rA.radioSongs.Length * 10 - 10;
    }

    // Update is called once per frame
    void Update()
    {
        SongID = (int)cD.outAngle;
        SongID = SongID / 10;

        if (currentID != SongID)
        {
            rA.togChange = true;

        }

        currentID = SongID;
    }
}
