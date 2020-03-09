using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{

    public bool movementEnabled = false;
    public Vector3 target;

    public float speed;
    public float timeLeft = 30.0f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (movementEnabled)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 5 * Time.deltaTime);
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                movementEnabled = false;
                timeLeft = 5;
            }
        }
    }

    public void MoveFromTo( Vector3 thisTarget )
    {
        target = thisTarget;
        target.z = transform.position.z;
        movementEnabled = true;
    }
}
