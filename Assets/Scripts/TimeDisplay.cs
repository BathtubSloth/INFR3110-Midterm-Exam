﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class TimeDisplay : MonoBehaviour
{
    public float timeSeconds;
    public int timeMinutes;
    public Text timer;
    public Text splitDisplay1;
    public Text splitDisplay2;
    public Text splitDisplay3;
    public Text splitDisplay4;
    public Text splitDisplay5;
    public Text splitDisplay6;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
        UpdateSplit1();
        UpdateSplit2();
        UpdateSplit3();
        UpdateSplit4();
        UpdateSplit5();
        TotalTime();
        //DontDestroyOnLoad(splitDisplay1);
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

    // Super unoptimized and hardcoded but I'm just trying to finish here
    public void UpdateSplit1()
    {
        splitDisplay1.text = "Checkpoint 1: " + PluginHandler.LoadTimeTest(1).ToString("f2");
    }

    public void UpdateSplit2()
    {
        splitDisplay2.text = "Checkpoint 2: " + PluginHandler.LoadTimeTest(2).ToString("f2");
    }

    public void UpdateSplit3()
    {
        splitDisplay3.text = "Checkpoint 3: " + PluginHandler.LoadTimeTest(3).ToString("f2");
    }

    public void UpdateSplit4()
    {
        splitDisplay4.text = "Checkpoint 4: " + PluginHandler.LoadTimeTest(4).ToString("f2");
    }

    public void UpdateSplit5()
    {
        splitDisplay5.text = "Final Time: " + PluginHandler.LoadTimeTest(5).ToString("f2");
    }

    public void TotalTime()
    {
        splitDisplay6.text = "Total Time: " + PluginHandler.LoadTotalTimeTest().ToString("f2");
    }
}

