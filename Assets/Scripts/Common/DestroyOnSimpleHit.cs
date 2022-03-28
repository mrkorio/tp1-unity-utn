using UnityEngine;
using System.Collections;

public class DestroyOnSimpleHit : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

}
