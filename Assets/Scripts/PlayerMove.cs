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
    public LayerMask groundLayer; // to be able to set objects as ground
    private bool isGrounded;
    public float groundCheckCircle;
    public Transform pawsPosition;
    public float jumpTime = 0.2f; // time the player's jump can be held before character comes back down
    public float jumpTimeCounter; // counts how long the jump has left
    private bool isJumping;

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

        // check if player is on ground before allowed to jump again
        isGrounded = Physics2D.OverlapCircle(pawsPosition.position, groundCheckCircle, groundLayer);

        // player jumping, checks to also see if the jump button is pressed, initates the jump
        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime; // timer gets reset with every jump
            playerRb.velocity = Vector2.up * jumpForce;
        }

        // if the jump button is to be held down
        if (Input.GetButton("Jump") && isJumping == true) // can't jump whilst falling
        {
            if(jumpTimeCounter > 0) // if there is time left, can hold jump
            {
                playerRb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime; // makes the timer count down
            }

            else
            {
                isJumping = false; // if timer runs out or stop pressing jumping
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2(input * speed, playerRb.velocity.y);
    }
}
