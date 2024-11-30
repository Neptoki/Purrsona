using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public AnimatorOverrideController evolvedAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            GetComponent<Animator>().runtimeAnimatorController = evolvedAnim as RuntimeAnimatorController;
        }
    }
}
