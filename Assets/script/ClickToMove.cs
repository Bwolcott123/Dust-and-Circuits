using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickToMove : MonoBehaviour 
{

	public float shootDistance = 10f;
	public float shootRate = .1f;
	/*
	public PlayerShooting shootingScript;
	*/
	public float speed = 1.5f;
	public GameObject point;
	public float timeLeft = 30.0f;

	private Vector3 target;
	
	public bool move = false;
    public bool select = false;
    public allowedMove allowedMove;
    public GameObject soldier;


    void Start () 
	{
		target = transform.position;

      
        
	}


	void Update () 
	{		
		if (Input.GetMouseButtonDown (0))
		{ // get input from the mouse
			if (select == false)
            { //checks if the unit is selected
                allowedMove unit = (allowedMove)GetComponent((typeof(allowedMove)));
                select = unit.Selected ();
		    } else
            {
				Debug.Log ("error 4");
				target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				target.z = transform.position.z;
				if (move == false)
					move = true;
				Instantiate (point, target, Quaternion.identity);
				select = false;
			}
		}

			if (move == true)
				transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
			if (move == true) {
				timeLeft -= Time.deltaTime;
				if (timeLeft < 0) {
					move = false;
					timeLeft = 5;
				}
			}
			if (move == false) {
				timeLeft -= Time.deltaTime;
				if (timeLeft < 0) {
					move = true;
					timeLeft = 5;
				}
			}
			
	}
			    
}


/* float timeLeft = 30.0f;
     
     void Update()
     {
         timeLeft -= Time.deltaTime;
         if(timeLeft < 0)
         {
             GameOver();
         }
     }
 
*/
/*else if (select == true) // this will check for buttons 
{
	Debug.Log ("error 1");
	RaycastHit hit;
	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

	if (Physics.Raycast(ray, out hit)) 
	{
		Debug.Log ("error 2");
		if (hit.transform.tag == "button")
			Debug.Log ("error 3");
		select = false;
	}
}*/