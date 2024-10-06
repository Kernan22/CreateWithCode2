 using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // To allow for movement using the arrow keys
    public float horizontalInput;
    // Set movement speed
    public float speed = 10.0f;
    // set boundary
    public float xRange = 10.0f;
    // Set object
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("HorizontalInput");
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

       //Keep player within bounds
       if (transform.position.x < -xRange) 
       {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       }
       if (transform.position.x > xRange)
       {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
       }
       // Space bar to launch projectile
       if (Input.GetKeyDown(KeyCode.Space))
       {
        // Launch a projectile from the player
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
       }
    }
}
