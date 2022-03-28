using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;
    public string actionName;
    public float time = 1f;
    public float repeatRate = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(actionName))
        {
            InvokeRepeating("Shoot", time, repeatRate);
        }

        if (Input.GetButtonUp(actionName))
        {
            CancelInvoke("Shoot");
        }
    }

    private void Shoot()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}