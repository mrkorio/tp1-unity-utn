using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float maxStartWait = 2f;     
    public float smoothing;         // control the smoothness of the manouver
    private Rigidbody rb;  
    private float targetManouver;   // target position
    public Boundary boundary;       // limit the object so it doesn't go out of boundary
    public float dodge;             // dodge factor
    public float tilt;              // tilt factor

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("Evade", Random.Range(.1f, maxStartWait));
    }

    void Evade()
    {
        targetManouver = Random.Range(1, dodge * -Mathf.Sign(transform.position.x));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newManouver = Mathf.MoveTowards(rb.velocity.x, targetManouver, Time.deltaTime * smoothing);
        rb.velocity = new Vector3(newManouver, 0, rb.velocity.z);
        rb.position = new Vector3
            (
                Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
                0,
                Mathf.Clamp(rb.position.z, boundary.zMin - 20, boundary.zMax + 20)   // added offset so that DestroyByBoundary will destroy the object and not keep clamping the position
            );

        rb.rotation = Quaternion.Euler(0, 0, rb.velocity.x * -tilt);
    }
}
