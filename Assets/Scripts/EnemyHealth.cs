using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 3; // enemy health
    public float health;
    public EnemyHealthbar Healthbar; // ref to health bar UI

    void Start()
    {
        Healthbar.SetHealth(health, maxHealth);
    }

    public void TakeDamage(int damageAmount) // reduces enemy health
    {
        health -= damageAmount;
        Healthbar.SetHealth(health, maxHealth);
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Destroy(Healthbar.gameObject);
    }
}
