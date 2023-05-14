using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script makes the camera follow the hero
public class CameraFollower : MonoBehaviour
{
    // Reference to the hero or any other object we could track
    public GameObject trackedObject;

    // Initial position of the camera
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        // Lets record initial camera position
        offset = transform.localPosition;
    }


    // Update is called once per frame
    void Update()
    {
        // If hero is destroyed, then we cant do the following logic, so lets check for that
        if (trackedObject != null)
        {
            // Get current tracked object position
            Vector3 trackedPosition = trackedObject.transform.localPosition;
            // Clear y position, because we dont want camera to move up or down (at least for now)
            trackedPosition.y = 0;
            // Set new position, which is combination of the position of the tracked object and initial camera position
            transform.localPosition = trackedPosition + offset;
        }
    }
}
