using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Make animals objects
    public GameObject [] animalPrefabs;
    //Make ball objects
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
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
       InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
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
    
    //Spawn random ball at random x position
    void SpawnRandomBall () 
    {
            int randomBallIndex = Random.Range(0, ballPrefabs.Length);
    
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[randomBallIndex], spawnPos, ballPrefabs[randomBallIndex].transform.rotation);
            
    }
}
