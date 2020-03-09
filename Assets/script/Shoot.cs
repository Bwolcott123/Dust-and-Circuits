using System.Collections;
using System.Collections.Generic;
using script.Game;
using UnityEngine;

public class Shoot : MonoBehaviour {


	void Update ()
	{
		//fire will be called by aim in the future
		fire ();
	}
	// this is the aimming system copyed into the shooting future build will need to 
	// call the aim.cs to get target.
	public GameObject FindClosestEnemy()
	{
		//gos is a place holder 
		GameObject[] gos;
		// all enemies will be tagged
		gos = GameObject.FindGameObjectsWithTag("enemies");
		// closest stores target data
		GameObject closest = null;
		// copyed range finder.
		float distance = Mathf.Infinity;
		Vector3 position = transform.position;
		foreach (GameObject go in gos)
		{
			Vector3 diff = go.transform.position - position;
			float curDistance = diff.sqrMagnitude;
			if (curDistance < distance)
			{
				closest = go;
				distance = curDistance;
			}
		}
		return closest;
	}

	public Weapon weapon; // Weapon static data. Should not be changed from here!
	public int usedClip = -1; // # of shots used start at clip
	public int shotFired; //# of shots fired in the burst
	public int hit; // holds random # for hit check
	public GameObject target; // set to hold aim target data in the future now holds current shoot aim data. 
	public float timeLeft; //time left to reload
	public Life Life; // script with enemy health and takeDamage function

	void fire() // function to start shoot and reload.
	{
		if (usedClip == -1)
		{
			usedClip = weapon.clip;
		}

		timeLeft -= Time.deltaTime;
		if (timeLeft < 0)
		{
			timeLeft = weapon.reload;
			shoot();
		}
	}

	void shoot() // fire at target and deal damage
	{
		target = FindClosestEnemy();
		//Life = target.GetComponents<Life>;
		if (target != null && target.CompareTag("enemies"))
		{
			while (shotFired < weapon.rof) //starts a burst
			{
				hit = Random.Range(0, weapon.accuracy); // looks for a hit
				Debug.Log(hit);
				if (hit == 1)
				{
					Life other = (Life) target.GetComponent(typeof(Life)); //calls other script to do damage
					other.takeDamage(weapon.damage);
				}

				shotFired += 1; //moves shotFired towards rof
				usedClip -= 1; // lowers usedClip to 0
				if (usedClip == 0)
				{
					usedClip = weapon.clip; // reloads usedClip
					shotFired = weapon.rof; //ends loop to start reload animation in the future
				}
			}

			shotFired = 0; //resets shotFired
		}
	}
}
