using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointsc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Object.Destroy(this.gameObject, 1.0f);
		if (Input.GetMouseButtonDown (0))
			GameObject.Destroy (this.gameObject);
	}
}
