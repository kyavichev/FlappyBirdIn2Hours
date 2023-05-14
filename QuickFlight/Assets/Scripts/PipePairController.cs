using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PipePairController : MonoBehaviour
{
    // Hero object
    public GameObject trackedObject;

    // Distance to reset
    public float dist = 5;

    // start position
    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
    }


    // Update is called once per frame
    void Update()
    {
        if ( trackedObject != null )
        {
            if ((transform.localPosition.x) < (trackedObject.transform.localPosition.x - dist))
            {
                Vector3 position = trackedObject.transform.localPosition;
                position.y = 0;
                position.x += dist;
                transform.localPosition = position;
            }
        }
        else
        {
            transform.localPosition = startPosition;
        }
    }
}
