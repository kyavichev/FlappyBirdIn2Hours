using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script destroys the game object once it collides with something
public class CollisionDestroyer : MonoBehaviour
{
    // This function is automatically called by the Unity engine once a collision is detected
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // This destroys the object
        Destroy(gameObject);
    }
}
