using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetector : MonoBehaviour
{

    float lastTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider cp)
    {
        float currentTime = Time.time;
        float checkpointTime = currentTime - lastTime;
        lastTime = currentTime;

        if (cp.tag == "checkpoint")
        {
            PluginHandler.SaveTimeTest(checkpointTime);
        }

        if (cp.tag == "final checkpoint")
        {
            PluginHandler.SaveTimeTest(checkpointTime);
            SceneSwitcher.SwitchSceneToEnd();
        }
    }
}
