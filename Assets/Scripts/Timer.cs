using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float startingTime;
    private Text theText;
    private float endTime;
    private bool finish = true;

	// Use this for initialization
	void Start ()
    {
        theText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        startingTime -= Time.deltaTime;
        theText.text = "" + Mathf.Round (startingTime);
        endTime = 0;

        if (finish == false)
        {
            SceneManager.LoadScene("Completed levels 1");
        }
	}
}
