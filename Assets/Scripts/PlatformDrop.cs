using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // lets player fall down ground
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(FallTimer());
        }
    }

    // similar to normal functions, disables player collider, pauses the code, then turns the collider back on
    IEnumerator FallTimer()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(0.15f);
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
