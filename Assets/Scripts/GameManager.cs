using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isEnded = false;

    public Rotator rot;
    public Spawner spawn;

    public Animator animator;

    public void EndGame()
    {
        if(isEnded) return;

        rot.enabled = false;
        spawn.enabled = false ;
        animator.SetTrigger("End");
        isEnded = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
