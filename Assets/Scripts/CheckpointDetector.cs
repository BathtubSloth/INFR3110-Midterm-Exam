using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CheckpointDetector : MonoBehaviour
{ 
    float lastTime = 0.0f;
    bool isStartTrigger = false;

    private void OnTriggerEnter(Collider cp)
    {
        float currentTime = Time.timeSinceLevelLoad;
        float checkpointTime = currentTime - lastTime;

        //Start trigger to save the first time to better show differences between splits
        if (isStartTrigger == false && cp.tag == "start checkpoint")
        {
            PluginHandler.ResetLoggerTest(); // reset the logger ONLY upon starting a new level, this allows the stats menu to not reset until a new run has begun
            isStartTrigger = true;
            PluginHandler.SaveTimeTest(checkpointTime);
        }

        if (cp.tag == "checkpoint" || cp.tag == "final checkpoint") // this if structure exists because I had weird errors with time when bumping into walls, this alleviates the issue
        {
            lastTime = currentTime;
        }

        //Generic checkpoint tag : IF I HAVE TIME MAKE IT SO CHECKPOINTS CAN NOT BE RE-TRIGGERED. re-triggering makes times meaningless.
        if (cp.tag == "checkpoint")
        {
            PluginHandler.SaveTimeTest(checkpointTime);
            UnityEngine.Debug.Log(PluginHandler.LoadTotalTimeTest());
        }

        //Final checkpoint logs time and swaps scene.
        if (cp.tag == "final checkpoint")
        {
            PluginHandler.SaveTimeTest(checkpointTime);
            UnityEngine.Debug.Log(PluginHandler.LoadTotalTimeTest());
            SceneSwitcher.SwitchSceneToEnd();
        }
    }
}