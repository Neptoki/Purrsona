using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySquash : MonoBehaviour
{
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
        if (collision.collider.CompareTag("Weak Point"))
        {
            GameObject enemy = collision.collider.transform.parent?.gameObject;
            if (enemy != null && enemy.CompareTag("Enemy"))
            {
                Destroy(enemy);
            }
        }
    }
}
