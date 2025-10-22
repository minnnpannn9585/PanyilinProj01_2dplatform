using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool isOnGround;

    void Update()
    {
        
        
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = true;
        }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (isOnGround)
            {
                rb.AddForce(jumpForce * Vector2.up,  ForceMode2D.Impulse);
                GetComponent<AudioSource>().Play();
            }
            
        }
    }

    
}
