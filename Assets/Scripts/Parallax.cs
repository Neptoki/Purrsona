using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{
    public Camera cam;
    public Transform subject;

    Vector2 startPosition;
    float startZ;

    Vector2 travel => (Vector2)cam.transform.position - startPosition;
    // this is the distance from the subject
    float distanceFromSubject => transform.position.z - subject.position.z;
    // closest clipping plain, takes the cameras position
    float clippingPlane => (cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane));

    // defining parallax factor
    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingPlane;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = startPosition + travel * parallaxFactor;
        // make sure not resetting transform's z position every time
        transform.position = new Vector3(newPos.x, newPos.y, startZ);
    }
}
