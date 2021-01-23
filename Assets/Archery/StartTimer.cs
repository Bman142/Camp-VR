using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    [SerializeField] Valve.VR.InteractionSystem.Sample.ArcheryCountdownTimer timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void TimerStart()
    {
        timer.StartCoroutine(timer.TimerTake());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
