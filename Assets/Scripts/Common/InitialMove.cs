using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialMove : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        if(rb != null)
        {
            rb.velocity = transform.forward * speed;
        }
    }

}
