using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;
    public PlayerMove playerMovement; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerMovement.KBCounter = playerMovement.KBTotalTime;
            if(collision.transform.position.x <= transform.position.x)
            {
                playerMovement.KnockFromRight = true;
            }
            if (collision.transform.position.x > transform.position.x)
            {
                playerMovement.KnockFromRight = false;
            }
            playerHealth.TakeDamage(damage);
        }
    }
}
