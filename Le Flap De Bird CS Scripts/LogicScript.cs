using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Enables the use of UI keywords. For this instance it was context menu
using UnityEngine.SceneManagement;
using System.Net.Security;
// Allows you to manage scenemanagement. So allows me to resart game in this sense. 

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource collisionSFX;
    public AudioSource highScoreSFX;
    public AudioSource dingSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }
    //This is the add score function it can be called using this logic script once attached to another script
    // here it wiill take the current score, then add an int varible
    //The lower code ensure player score is set to a sstring varible so the text in the UI can read it. 
    // This is because to a PC a Int and String are different variables.

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //Uses scene manager to load a screen, refers to screenmanager to select a scene.

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    //sets game over screen to true

}
