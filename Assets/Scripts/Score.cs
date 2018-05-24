using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text score;
    public float scorevalue = 0;

    


    private void Update()
    {
        score.text = "" + scorevalue;
    }

}
