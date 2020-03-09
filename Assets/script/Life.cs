using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour 
{

	public float health = 50f;

	public void takeDamage (float damage)
	{
		health -= damage;
		if (health <= 0f) 
		{
			die();
		}
	}


	void die ()
	{
        Destroy(transform.parent.gameObject);
        Destroy (gameObject);
	}
}