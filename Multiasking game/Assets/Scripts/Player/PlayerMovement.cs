using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //got the movement for this from https://www.youtube.com/watch?v=n4N9VEA2GFo
    public float moveSpeed = 1f;
    public float jumpForce = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //movement with the left and right arrow keys
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;

        //sapce bar to jump
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.0001f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

    }
}
