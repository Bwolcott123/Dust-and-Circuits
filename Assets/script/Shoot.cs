using System.Collections;
using System.Collections.Generic;
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

	public int clip ;// # of shots per reload
	public int usedClip= -1;// # of shots used start at clip
	public int rof; // # of hit checks per burst
	public int shotFired; //# of shots fired in the burst
	public float spread;//max disdens from target miss can landed
	public float damage;//how much it hurts
	public float reload;//time to reload
	public int accuracy; //chance to hit
	public int hit; // holds random # for hit check
	public GameObject target;// set to hold aim target data in the future now holds current shoot aim data. 
	public float timeLeft; //time left to reload
	public Life Life; // script with enemy health and takeDamage function
	void fire () // function to start shoot and reload.
	{
		if (usedClip == -1) 
		{
			usedClip = clip;
		}
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			timeLeft = reload;
			shoot ();

		}
	}
	void shoot()// fire at target and deal damage
	{
		
		target = FindClosestEnemy ();
		//Life = target.GetComponents<Life>;
		if (target.tag == "enemies") 
		{
			while (shotFired < rof) //starts a burst
			{
				hit = Random.Range (0, accuracy);// looks for a hit
				Debug.Log (hit);
				if (hit == 1) 
				{
					Life other = (Life)target.GetComponent (typeof(Life));//calls other script to do damage
					other.takeDamage (damage);
				}
				shotFired += 1;//moves shotFired towards rof
				usedClip-=1; // lowers usedClip to 0
				if (usedClip == 0)
				{
					usedClip = clip;// reloads usedClip
					shotFired= rof; //ends loop to start reload animation in the future
				}
			}
			shotFired = 0;//resets shotFired
		}
	}
}
