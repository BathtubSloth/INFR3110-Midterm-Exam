using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;

public class PluginHandler : MonoBehaviour
{
    const string DLL_NAME = "EnginesDLLTutorial";

    //METHODS
    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    //SETTERS
    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    //GETTERS
    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    public static void SaveTimeTest(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadTimeTest(int index)
    {
        if (index >= GetNumCheckpoint())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpointTime(index);
        }
    }

    public static float LoadTotalTimeTest()
    {
        return GetTotalTime();
    }

    public static void ResetLoggerTest()
    {
        ResetLogger();
    }


    float lastTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {      
        for (int i = 0; i < 10; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha0+i))
            {
                UnityEngine.Debug.Log(LoadTimeTest(i));
            }
        }
    }

    void OnDestroy()
    {
        ResetLoggerTest();
    }
}
