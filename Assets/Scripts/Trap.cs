using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Time.timeScale = 0f; // Pause the game
            
        }
    }
}
