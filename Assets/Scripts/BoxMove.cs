using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpForce;

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(jumpForce * Vector2.up,  ForceMode2D.Impulse);
        }
    }
}
