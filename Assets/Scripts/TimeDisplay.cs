using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public float timeSeconds;
    public int timeMinutes;
    public Text timer;
    public Text splitDisplay;
    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    //This function updates the timer to display in a minutes:seconds:milliseconds to 2 decimal places
    public void UpdateTimer()
    {
        timeSeconds += Time.deltaTime;
        timer.text = timeMinutes + ":" + timeSeconds.ToString("f2");
        if (timeSeconds >= 60)
        {
            timeMinutes++;
            timeSeconds = 0;
        }
    }
    
    /*
    public void UpdateSplit()
    {
        for (int i = 0; i < 4; i++)
        {
            splitDisplay.text = PluginHandler.LoadTimeTest(i);
        }
    }
    */
}

