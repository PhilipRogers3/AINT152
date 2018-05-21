using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponDamage : MonoBehaviour
{
    public int damage = 10;

	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Collider2D>().enabled = true;
        }


        if(Input.GetMouseButtonUp(0))
        {
            GetComponent<Collider2D>().enabled = false;
        }
	}
	

	void OnTriggerEnter2D (Collider2D other)
    {
        other.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
	}
}
