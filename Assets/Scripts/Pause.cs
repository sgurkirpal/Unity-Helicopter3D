using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    
    public void onPointerDown(string data)
    {
        SceneManager.LoadScene(data);
    }

    public void resumeButton(string data)
    {
        SceneManager.LoadScene(data);
    }

    public void exitCode()
    {
        Application.Quit();
    }
}
