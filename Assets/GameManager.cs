using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    
    private bool gameEnded = false;
    public spawner spawner;
    public rollBall rollBall;
    public Animator animator;

    public void EndGame(){
        spawner.enabled = false;
        rollBall.enabled = false;
        animator.SetTrigger("EndGame");

        gameEnded = true;

    }

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quitGame(){
        
            Application.Quit();

    }

    public void backButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
