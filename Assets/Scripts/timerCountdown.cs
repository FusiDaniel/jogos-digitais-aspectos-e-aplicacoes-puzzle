using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerCountdown : MonoBehaviour
{
    public float TimeElapsed;
    public bool TimerOn;

    public string TimerTxt = "00:00";

    public void setTimeLeft(float time)
    {
        TimeElapsed = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            TimeElapsed += Time.deltaTime;
            updateTime(TimeElapsed);
        }
    }

    void updateTime(float time)
    {
        time += 1;

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        TimerTxt = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
