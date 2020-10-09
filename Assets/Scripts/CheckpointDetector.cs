using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetector : MonoBehaviour
{ 
    float lastTime = 0.0f;
    

    private void OnTriggerEnter(Collider cp)
    {
        float currentTime = Time.time;
        float checkpointTime = currentTime - lastTime;

        if (cp.tag == "checkpoint" || cp.tag == "final checkpoint") // this if structure exists because I had weird errors with time when bumping into walls, this alleviates the issue
        {
            lastTime = currentTime;
        }

        if (cp.tag == "checkpoint")
        {
            PluginHandler.SaveTimeTest(checkpointTime);
            UnityEngine.Debug.Log(PluginHandler.LoadTotalTimeTest());
        }

        if (cp.tag == "final checkpoint")
        {
            PluginHandler.SaveTimeTest(checkpointTime);
            UnityEngine.Debug.Log(PluginHandler.LoadTotalTimeTest());
            SceneSwitcher.SwitchSceneToEnd();
        }
    }
}