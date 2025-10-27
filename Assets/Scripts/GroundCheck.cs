using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public BoxMove player;

    private void Start()
    {
        player = transform.parent.GetComponent<BoxMove>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground") || other.CompareTag("Box"))
        {
            player.isOnGround = true;
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ground") || other.CompareTag("Box"))
        {
            player.isOnGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground") || other.CompareTag("Box"))
        {
            player.isOnGround = false;
        }
    }
}
