using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3; // enemy health

    public void TakeDamage(int damageAmount) // reduces enemy health
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
