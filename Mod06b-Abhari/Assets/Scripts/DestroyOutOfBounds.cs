using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40;
    private float lowerBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            UnityEngine.Debug.Log("Game Over!");
        }
    }
}
