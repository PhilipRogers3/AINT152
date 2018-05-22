using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour
{

    int moneyAmount;
    int isGuitarSold;

    public Text moneyAmountText;
    public Text guitarPrice;

    public Button buyButton; 


	void Start ()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
	}
	
	
	void Update ()
    {
        moneyAmountText.text = "Money" + moneyAmount.ToString() + "£";

        isGuitarSold = PlayerPrefs.GetInt("isGuitarSold");

        if (moneyAmount >= 25 && isGuitarSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
	}

    public void buyElectric()
    {
        moneyAmount -= 25;
        PlayerPrefs.SetInt("isGuitarSold", 1);
        guitarPrice.text = "Sold";
        buyButton.gameObject.SetActive(false);
    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("Main Menu");
    }

    public void resetPlayerPrefs()
    {
        moneyAmount = 0;
        buyButton.gameObject.SetActive(true);
        guitarPrice.text = "Price £25";
        PlayerPrefs.DeleteAll();
    }
}
