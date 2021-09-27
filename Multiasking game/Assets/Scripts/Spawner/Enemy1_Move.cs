using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    void Start()
    {       //the movement of the bullet
        rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {       //when colliding with the player, destroys the player
        Destroy(col.gameObject);
    }
}
