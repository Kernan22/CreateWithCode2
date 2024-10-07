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
    // Spawn at timed intervals
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    { 
    
        
    }
    void SpawnRandomAnimal()
    {
        // Random animal spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
