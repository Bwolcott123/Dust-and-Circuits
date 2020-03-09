using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour 
{
	private Rigidbody2D rb2D;

	public float speed;
    public float baseSpeed;
   
    public float moveTime;
    public float baseMoveTime;
    public float waitTime;
    public float baseWaitTime;


    void Start()
	{
		rb2D = GetComponent<Rigidbody2D>();
		
	}
    void Update ()
    {
        rb2D.velocity = -transform.up * speed;
        moveTime -= Time.deltaTime;
        if (moveTime <= 0)
        {
            speed = 0;
            waitTime -= Time.deltaTime; 
            if (waitTime<=0)
            {
                speed = baseSpeed;
                moveTime = baseMoveTime;
                waitTime = baseWaitTime;

            }

        }
        

    }
}
