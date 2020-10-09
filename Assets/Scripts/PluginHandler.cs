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

    public static float LoadTimeTest(int index)
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
        UnityEngine.Debug.Log("ahh");
    }


    float lastTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
    }

    
}
