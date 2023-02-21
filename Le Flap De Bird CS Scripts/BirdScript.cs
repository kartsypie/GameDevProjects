using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public Animator wingAnimator; 


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        wingAnimator.SetBool("AnimBirdIsAlive", true);
    }

    //Commented the explaination in Pipe middle script

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && (birdIsAlive == true))
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        //Moves on a 2d space, upwards, based on the velocity using the flapstrength figure
        //that score is edited in the inspector

        if (transform.position.y > 15 || transform.position.y < -14.5)
        {
            logic.gameOver();
            birdIsAlive = false;
            wingAnimator.SetBool("AnimBirdIsAlive", false);
        }
        //runs gameover Ui script, makes the birds bool say false
        //This happens if the bird is above 15 Y height or below -14.5 Y height
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.collisionSFX.Play();
        logic.gameOver();
        birdIsAlive = false;
        wingAnimator.SetBool("AnimBirdIsAlive", false);
    }
    //runs gameover Ui script, makes the birds bool say false
}
