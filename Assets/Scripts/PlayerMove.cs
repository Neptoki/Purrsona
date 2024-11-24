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
    private Animator anim; // cat animations
    private float idleTime = 0f; // player idle
    private bool isSpecialIdleTriggered = false; // special anim played?
    public float idleThreshold = 5f; // special anim plays
    public int numberOfIdleVariants = 2; // total anim variants
    public float KBCounter; // KB = 'knocknack'
    public float KBForce;
    public float KBTotalTime;
    public bool KnockFromRight; // direction player has been hit

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerRb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        anim.SetBool("isWalking", input != 0); // if input is zero, for animation

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
        anim.SetBool("isGrounded", isGrounded); // parameter for animation

        // player jumping, checks to also see if the jump button is pressed, initates the jump
        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime; // timer gets reset with every jump
            playerRb.velocity = Vector2.up * jumpForce;
            anim.SetBool("isJumping", true); // starts jump animation
            ResetSpecialIdle(); // stops idle when jumping
        }

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }

        else
        {
            anim.SetBool("isJumping", true);
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

        if (isGrounded)
        {
            anim.SetBool("isJumping", false); // stops animation when grounded
        }

        // animation
        anim.SetBool("isInAir", !isGrounded && !isJumping); // when not grounded and jumping

        if (input == 0 && isGrounded) // is idle and grounded
        {
            idleTime += Time.deltaTime; // idle timer

            if (idleTime >= idleThreshold && !isSpecialIdleTriggered)
            {
                int randomVariant = Random.Range(1, numberOfIdleVariants + 1); // randoms
                anim.SetInteger("idleVariant", randomVariant); // variant
                anim.SetTrigger("specialIdle"); // special idle animation
                isSpecialIdleTriggered = true; // not repeatedly triggered
            }
        }
        else
        {
            // resets idle
            ResetSpecialIdle();
        }

        if (isSpecialIdleTriggered && anim.GetCurrentAnimatorStateInfo(0).IsTag("SpecialIdle")) // resets again
        {
            if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) // complete
            {
                idleTime = 0f;
                isSpecialIdleTriggered = false;
            }
        }
    }

    void FixedUpdate()
    {
        if(KBCounter <=0)
        {
            playerRb.velocity = new Vector2(input * speed, playerRb.velocity.y);
        }
        else
        {
            if(KnockFromRight == true)
            {
                playerRb.velocity = new Vector2(-KBForce, KBForce);
            }   
            if (KnockFromRight == false)
            {
                playerRb.velocity = new Vector2(KBForce, KBForce); // sends player right
            }

            KBCounter -= Time.deltaTime;    
        }
    }   

    void ResetSpecialIdle() // for idle anims
    {
        if (isSpecialIdleTriggered)
        {
            anim.ResetTrigger("specialIdle"); // trigger
            idleTime = 0f;
            isSpecialIdleTriggered = false;
        }
    }
}
