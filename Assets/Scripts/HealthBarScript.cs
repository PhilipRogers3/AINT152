using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    Image healthBar;
    float maxHealth = 100f;
    public static float health;

	void Start ()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
        PlayerBehaviour.OnUpdateHealth += HandleonUpdateHealth;
	}
	
	void HandleonUpdateHealth (int newHealth)
    {
        healthBar.fillAmount = newHealth / maxHealth;
		
	}
}
