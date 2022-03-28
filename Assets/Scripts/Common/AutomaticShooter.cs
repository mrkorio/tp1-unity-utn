using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticShooter : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    // This is called when the bullet instance is created
    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);   
    }

    void Fire()
    {

        if (shot == null)
        {
            return;
        }
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }

    public void SetInitialValue(GameObject shotType)
    {
        this.shot = shotType;
    }
}

