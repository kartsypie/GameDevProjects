using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movespeed = 5;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        // considently moves it left
        //time.delta ensures it happens based every second so it runs the same on every device
        //using time not frame rate

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
    // Destroys this game object
}
