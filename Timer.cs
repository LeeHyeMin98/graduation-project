using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class Timer : MonoBehaviour
{
    public Text timeText;
    private float time;


    private void Update()
    {
        time += Time.deltaTime;

        timeText.text = "Time:" + Mathf.Round(time) +" second";

    }

    //void SetData()
    //{
    //    PlayerPrefs.SetInt("Time", int.Parse(timeText.text));
    //    PlayerPrefs.SetInt("Coin", coin);
    //    PlayerPrefs.Save();
    //}

    //public void save()
    //{
    //    PlayerPrefs.SetInt("Time", int.Parse(timeText.text));

    //}
    //public void Load()
    //{
    //    if (PlayerPrefs.HasKey("Name"))
    //    {
    //        timeText.text = PlayerPrefs.GetInt("Time").ToString();
    //    }
    //}
}
