using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    public int duration = 5; // In seconds

    public GameObject playerRef;

    public abstract void ExecutePowerUp(GameObject player);

    public virtual void DismissPowerup()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ExecutePowerUp(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
