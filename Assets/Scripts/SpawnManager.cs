using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Make animals objects
    public GameObject [] animalPrefabs;
    //Set up random animal spawn
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // Animal spawn on key press S
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Random animal spawn
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
