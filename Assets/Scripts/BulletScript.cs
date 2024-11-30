using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    public int damage = 1; // damage it does

    // Start is called before the first frame update
    void Start()
    {
        // bullet config, not changing speed, rotation fixes etc
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("Coin") || other.CompareTag("Heart") || other.CompareTag("Bullet") || other.CompareTag("Player") || other.CompareTag("Star")) // ignores these to not get destroyed
        {
            return;
        }

        DestroyProjectile();
        if (other.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>(); // enemy health
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
            DestroyProjectile();
        }
        else
        {
            DestroyProjectile();
        }

    }

    void DestroyProjectile()

    {

        Destroy(gameObject);

    }
}
