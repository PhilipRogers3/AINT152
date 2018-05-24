using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {

    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;

    public static int scorevalue = 10;
    public Text Score;

    void Start()
    {
        Score = GetComponent<Text>();
    }


    private void Update()
    {
        Score.text = "Score" + scorevalue;
    }
    public void DoSendScore()
    {
        if(OnSendScore != null)
        {
            OnSendScore(scorevalue);
        }
    }
}
