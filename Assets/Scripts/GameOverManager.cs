using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerBehaviour playerHealth;
    public float nextLevelDelay = 5f;

    Animator anim;
    float nextLevel;

    private void Awake()
    {
        anim = GetComponent<Animator>(); 
    }


    // Update is called once per frame
    void Update ()
    {
		if (playerHealth.health <=0)
        {
            anim.SetTrigger("Game Over");

            nextLevel += Time.deltaTime;
        }
	}
}
