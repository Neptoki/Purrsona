using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movSpeed;
    public float input;
    public float speed;
    public Rigidbody2D playerRb;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        playerRb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");

        // if player is facing left, right, etc, then flip the sprite
        if (input < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (input > 0)
        {
            spriteRenderer.flipX = false;
        }

        // player jumping, checks to also see if the jump button is pressed
        if (Input.GetButton("Jump"))
        {
            playerRb.velocity = Vector2.up * jumpForce;
        }

    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2(input * speed, playerRb.velocity.y);
    }
}
