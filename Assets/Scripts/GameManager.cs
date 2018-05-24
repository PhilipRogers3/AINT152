using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1 ");
    }

    public void CompleteLevel()
    {

        Debug.Log("LEVEL WON!");
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

