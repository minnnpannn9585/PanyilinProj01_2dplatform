using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<BoxMove>().AddScore();
            Destroy(gameObject);
            Instantiate(Resources.Load("DiamondVfx"), transform.position, Quaternion.identity);
        }
    }
}
