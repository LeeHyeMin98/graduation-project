using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class invenmanager : MonoBehaviour
{

    public Text coinmText;
    public static int coindata;
    int isRIfleSold;
    public GameObject rifle;
    // Start is called before the first frame update
    void Start()
    {
        coindata = PlayerPrefs.GetInt("Coindata");
        isRIfleSold = PlayerPrefs.GetInt("IsRifleSold");

        if (isRIfleSold == 1)
            rifle.SetActive(true);
        else
            rifle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        coinmText.text = "Coin :" + coindata.ToString() + "$";
    }
    public void gotoshop() {
        PlayerPrefs.SetInt("Coindata", coindata);
        SceneManager.LoadScene("item11");
    }
}
