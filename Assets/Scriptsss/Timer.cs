using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timeInterval;
    private float stoppedTime;
    public bool timerRunning;
    private TimeDisplay timeDisplay;


    // Start is called before the first frame update
    void Start()
    {
        timeDisplay = FindObjectOfType<TimeDisplay>();
    }

    public float GetTime()
    {

        float timeReadout;

        if (timerRunning)
        {
            timeReadout = Time.time - timeInterval;
        }
        else
        {
            timeReadout = stoppedTime;
        }

        return timeReadout;
    }


    public void ResetTimer()
    {
        timeInterval = Time.time;
        stoppedTime = 0;
    }
    
    public void StopTimer()
    {
        stoppedTime = Time.time - timeInterval;
        timeInterval = Time.time;
        timerRunning = false;
    }

    public void StartTimer()
    {
        ResetTimer();
        timerRunning = true;
    }

  
}
