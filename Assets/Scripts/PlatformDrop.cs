using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{
    private BoxCollider2D boxCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();

        if (boxCollider2D == null)
        {
            Debug.LogError("No BoxCollider2D attached to this GameObject!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // lets player fall down ground
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (boxCollider2D != null)
            {
                StartCoroutine(FallTimer());
            }
        }
    }

    // similar to normal functions, disables player collider, pauses the code, then turns the collider back on
    IEnumerator FallTimer()
    {
        if (boxCollider2D != null)
        {
            boxCollider2D.enabled = false;
            yield return new WaitForSeconds(0.15f);
            boxCollider2D.enabled = true;
        }
    }
}
