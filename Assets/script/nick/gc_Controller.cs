﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gc_Controller : MonoBehaviour {

    public Move unitMove;

    private Vector2 target;
    public float timeLeft = 30.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButtonDown(0) )
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                unitMove = hit.collider.gameObject.GetComponent<Move>();
            }
            else
            {
                unitMove.MoveFromTo(mousePos);
                unitMove = null;
            }

        } 
	}
}