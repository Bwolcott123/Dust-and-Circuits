using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allowedMove : MonoBehaviour
{

    
    // Use this for initialization
    void Start ()
    {
		
	}
    public bool Selected()
    {


        Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
            Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 0f); //casts ray to hit somthing

        if (hit)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        // Update is called once per frame
        void Update () {
		
	}
}
