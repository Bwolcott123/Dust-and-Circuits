using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Combatant : MonoBehaviour {

    public float shootDistance = 10f;
    public float shootRate = .1f;

    public float speed = 1.5f;
    public GameObject point;
    public float timeLeft = 30.0f;

    public bool isSelected = false;

    public GameObject gameController;

    public bool isMoving = false;
    public Vector3 target;

}
