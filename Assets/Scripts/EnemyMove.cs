using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    public Transform playerTransform; // helps communicate together
    public bool isChasing; // to keep track
    public float chaseDistance; // how close player is to trigger

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            if (transform.position.x > playerTransform.position.x) // if player is left
            {
                transform.localScale = new Vector3(1, 1, 1); // fixes bug with enemy not facing correctly
                transform.position += Vector3.left * moveSpeed * Time.deltaTime; // enemy moves towards player
            }
            if (transform.position.x < playerTransform.position.x) // if player is right
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position += Vector3.right * moveSpeed * Time.deltaTime; // enemy moves towards player
            }
        }

        else // patrols when not chasing
        {
            if(Vector2.Distance(transform.position, playerTransform.position) < chaseDistance) // if player is in correct distance, chase
            {
                isChasing = true;
            }

            if (patrolDestination == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime); // gets the enemy to go to the patrol point
                if (Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
                {
                    transform.localScale = new Vector3(-1, 1, 1); // fixes not flipping
                    patrolDestination = 1;
                }
            }

            if (patrolDestination == 1) // same but other way
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    patrolDestination = 0;
                }
            }
        }

        
    }
}
