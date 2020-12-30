using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
    }
    public void StartButton()
    {
        Invoke("startgame", .2f);
    }

    void startgame()
    {
        Application.LoadLevel("play");
    }
}

