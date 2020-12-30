using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(600, 1024, true);
    }
    public void OnStartClick() {
        SceneManager.LoadScene("good");
    }
    public void OnExitClick() {
        Application.Quit();
    }
    public void OnItemClick()
    {
        SceneManager.LoadScene("item11");
    }
    public void OnstoreClick()
    {
        SceneManager.LoadScene("setup");
    }
    public void OnmethodClick()
    {
        SceneManager.LoadScene("gamemethod");
    }
    public void OnmapSelectClick()
    {
        SceneManager.LoadScene("BackSelect");
    }
}
