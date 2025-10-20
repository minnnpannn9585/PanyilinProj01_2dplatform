using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public GameObject frame;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            GetComponent<AudioSource>().Play();

            
            Camera.main.GetComponent<AudioSource>().Pause();

            frame.GetComponent<Animator>().speed = 0;


            StartCoroutine(LoadNextLevelAfterDelay());
        }
    }

    IEnumerator LoadNextLevelAfterDelay()
    {
        yield return new WaitForSeconds(2);
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more levels to load.");
        }
    }
}
