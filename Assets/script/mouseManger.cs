using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseManger : MonoBehaviour 
{

	public GameObject selectedObject;
	// Use this for initialization
	void Start () {
		
	}

	void ClearSelection ()
	{
		selectedObject = null;
	}

	void SelectObject (GameObject obj)
	{
		if (selectedObject != null) 
		{
			if (obj == selectedObject)
				return;

			ClearSelection ();
		}
	}
	// Update is called once per frame
	void Update () 
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hitInfo;

		if (Physics.Raycast (ray, out hitInfo)) {

			GameObject hitObject = hitInfo.transform.root.gameObject;

			SelectObject (hitObject);
		}
		else 
		{
			ClearSelection ();
		}
	}
}
