using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    Image healthBar;
    float maxHealth = 100f;
    public static float health;

	// Use this for initialization
	void Start ()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
        PlayerBehaviour.OnUpdateHealth += HandleonUpdateHealth;
	}
	
	// Update is called once per frame
	void HandleonUpdateHealth (int newHealth)
    {
        healthBar.fillAmount = newHealth / maxHealth;
		
	}
}
