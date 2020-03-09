using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSoldier : MonoBehaviour
{

    public bool isMoving = false;
    public Vector3 target;
    public float speed;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }


}
