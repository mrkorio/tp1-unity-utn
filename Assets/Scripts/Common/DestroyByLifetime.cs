using UnityEngine;
using System.Collections;

public class DestroyByLifetime : MonoBehaviour
{
    public float lifetime = 10;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
   
}
