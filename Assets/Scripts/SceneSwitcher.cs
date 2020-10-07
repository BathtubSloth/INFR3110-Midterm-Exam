using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchSceneToStart()
    {
        SceneManager.LoadScene("Start Scene"); // from https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
    }
    
    public void SwitchSceneToPlay()
    {
        SceneManager.LoadScene("Play Scene"); //same as above, different scene
    }

    public void SwitchSceneToEnd()
    {
        SceneManager.LoadScene("End Scene"); // same as above, different scene
    }
}

