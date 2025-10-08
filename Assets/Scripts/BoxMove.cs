using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public Rigidbody2D rb;
    

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 2f, rb.velocity.y);
    }
}
