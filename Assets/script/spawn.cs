using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public GameObject gunner;
	// Use this for initialization
	public void boom () 
	{
		Vector3 position = new Vector3(Random.Range(-8.5f, 8.5f), 0, 0);  
		Instantiate (gunner, position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
