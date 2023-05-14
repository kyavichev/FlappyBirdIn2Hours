using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePositionRandomizer : MonoBehaviour
{
    public float range = 1;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 offset = new Vector3( 0, Random.Range(-range, range), 0);
        Vector3 pos = transform.localPosition;
        transform.localPosition = pos + offset;
    }
}
