using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script that initiates hero movement
public class HeroMover : MonoBehaviour
{
    // variables for a Rigidbody2D, a float and a Vector2 that we can set in the inspector
    // public means it is shown in the inspector
    // "Rigidbody2D" and "float" are the type of variable
    // "body", "speed" and "dir" are the custom names we give the variables

    // Physics body that we want to interact with
    public Rigidbody2D body;

    // Speed with which hero automatically moves
    public float speed = 1;
    // Direction in which hero automatically moves, by default to the right
    public Vector2 dir = new Vector2(1, 0);

    public bool isAutoStart = true;


    // Start is called before the first frame update
    private void Start()
    {
        if (isAutoStart)
        {
            // Set initial velocity on the hero's rigidbody
            body.velocity = dir * speed;
        }
    }

    public void StartMoving()
    {
        // Set initial velocity on the hero's rigidbody
        body.velocity = dir * speed;
    }
}
