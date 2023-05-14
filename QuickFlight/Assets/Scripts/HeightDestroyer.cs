using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script destroys hero if it falls too far down
public class HeightDestroyer : MonoBehaviour
{
    public float yThreshold = -2;


    // Update is called once per frame
    void Update()
    {
        // Check the height of the hero against threshold value
        if(transform.localPosition.y < yThreshold)
        {
            // Destroy the object
            Destroy(gameObject);
        }
    }
}
