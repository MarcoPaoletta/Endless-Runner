using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime) // if the current time is grather than the spawn time, so that we want to spawn a new obstacle
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn; // change the spawn time 
        }
    }

    void Spawn()
    {
        // create randoms positions
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // instantiate it using the random positions
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
