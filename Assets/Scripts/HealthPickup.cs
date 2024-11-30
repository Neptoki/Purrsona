using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;
    public float healthBonus = 1f;

    void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>(); // ref to player health
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (playerHealth.health < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.health = playerHealth.health + healthBonus; // takes current health and adds the bonus
        }
    }
}