using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate;
    private float timer = 0;
    public float heightOffset = 8;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }
    // Activates spawnpipe function. Found below in Void spawnPipe

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; 
        }
        // Every frame the code will check the timer and +1 one if its less than spawnrate, however;
        // it will check the first frame then wait a second.
        else
        {
            spawnPipe();
            timer = 0;
        }
        // If timer is the same as spawnrate, spawnpipe will run
        
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
// Spawns it at a random height within this range
}
