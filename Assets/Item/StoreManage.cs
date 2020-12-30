using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreManage : MonoBehaviour
{
    int moneyAmount;
    int isRifleSold;
    public static int coindata;

    public Text moneyAmountText;
    public Text riflePrice;
    public Text cointext;

    public Button buyButton;

    void Start()
    {
        //moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        coindata = PlayerPrefs.GetInt("Coin");
    }
    void Update()
    {
       // coindata = PlayerPrefs.GetInt("Coin", default);
       // moneyAmountText.text = "Coin:" + moneyAmount.ToString() + "$";
        cointext.text = "Coin:" + coindata.ToString() + "$";

        isRifleSold = PlayerPrefs.GetInt("IsRifleSold");
        if (coindata >= 0 && isRifleSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;

    }

    public void buyRifle()
    {
        coindata -=5;
       // moneyAmount -= 5;
        PlayerPrefs.SetInt("IsRifleSold", 1);
        riflePrice.text = "sold!";
        buyButton.gameObject.SetActive(false);
    }
    public void OnMainClick()
    {
       // PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        PlayerPrefs.SetInt("Coin", coindata);
        SceneManager.LoadScene("main");
    }

    public void OnresetClick()
    {
        coindata = 0;
        //moneyAmount = 0;
        buyButton.gameObject.SetActive(true);
        riflePrice.text = "Price :5$";
        PlayerPrefs.DeleteAll();
       
    }
    public void OninvClick()
    {
        // PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        PlayerPrefs.SetInt("Coin", coindata);
        SceneManager.LoadScene("inventory");
    }
}


