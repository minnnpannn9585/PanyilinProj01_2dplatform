using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //Debug.Log("Player hit a trap!");
            // Here you can add code to reduce player health or trigger a death animation
            collision.GetComponent<SpriteRenderer>().color = Color.red;
            GetComponent<AudioSource>().Play();
            //Time.timeScale = 0f; // Pause the game


            Invoke("BackToMainMenu", 1f); // Wait for 1 second before going back to main menu
            

        }

        void BackToMainMenu()
        {
            SceneManager.LoadScene(0);
            //Time.timeScale = 1f; // Resume the game
        }
    }
}
