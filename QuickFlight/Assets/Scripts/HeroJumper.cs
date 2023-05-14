using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Jumper script applies impulse to the rigidbody and causes our hero to move upwards
public class HeroJumper : MonoBehaviour
{
    // variables for a Rigidbody2D and a float that we can set in the inspector
    // public means it is shown in the inspector
    // "Rigidbody2D" and "float" are the type of variable
    // "body" and "jumpImpulseAmount" are the custom names we give the variables

    // Physics body that we want to interact with
    public Rigidbody2D body;

    // Impulse strength that can be configured via Unity Editor
    public float jumpImpulseAmount = 20;


    // Start is called before the first frame update
    void Start()
    {
        // Sometimes it is easier to have code look up a component for us,
        // rather than link it manually in the Editor.
        body = GetComponent<Rigidbody2D>();
    }


    // Public function that initiates a jump. Can be called by an another script
    public void Jump()
    {
        body.AddForce(new Vector2(0, jumpImpulseAmount), ForceMode2D.Impulse);
    }
}
