using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour {



    public void StartGame()
    {
        SceneManager.LoadScene("Level 1 ");
    }

    public void CompleteLevel()
    {

        SceneManager.LoadScene("Level 1");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void EnterShop()
    {
        SceneManager.LoadScene("Shop Scene");
    }
}
