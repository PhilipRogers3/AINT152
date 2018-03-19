using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Game"); // change this to the level 1 
    }
    
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("JAZZ");
    }
}
