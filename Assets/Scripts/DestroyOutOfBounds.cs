using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftLimit = -30.0f;
    private float floorLimit = -5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } else if (transform.position.y > floorLimit)
        {
            Destroy(gameObject);
        }
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
