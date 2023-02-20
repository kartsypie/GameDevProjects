using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript bird;
    
    //applies a public value for a script

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }
    //attaches object with the tag logic into the script space

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag ==("Player") && (bird.birdIsAlive == true))
        {
            logic.addScore(1);
            }
        //This checks the colliding trigger is tagged player and that bird is alive
        // previously i wrote " = true" and it made the bird alive
        //Seems adding "== true" just checked the code rather than change it.
    }
    //On collison will check if the collider has the player tag
    //relating to the logic script it will add the scor enumber in the brakcets.
    //Must be a Int value
}
