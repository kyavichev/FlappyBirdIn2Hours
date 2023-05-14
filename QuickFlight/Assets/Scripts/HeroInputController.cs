using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script manages input for our hero
public class HeroInputController : MonoBehaviour
{
    // Reference to the jumper script
    public HeroJumper jumper;


    // Update is called once per frame
    void Update()
    {
        // If we detect "up arrow" or "space bar" keys press, then we will cause the jumper script to jump.
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            jumper.Jump();
        }
    }
}
