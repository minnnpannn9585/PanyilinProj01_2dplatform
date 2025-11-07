using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour
{
    private AudioSource bgm;

    private void Start()
    {
        bgm = Camera.main.GetComponent<AudioSource>();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            //Time.timeScale = 0;
            GetComponent<AudioSource>().Play();
            if(bgm!=null)
                bgm.Pause();

            Invoke("BackToMainMenu", 1f);
        }
        
    }

    void BackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        //Time.timeScale = 1f; // Resume the game
    }
}
