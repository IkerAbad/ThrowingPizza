using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xRange = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > xRange || transform.position.z < -xRange || transform.position.x > xRange || transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
    }
}
