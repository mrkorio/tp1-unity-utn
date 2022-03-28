using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyManager enemyManager;
    public GameObject deathAnimation;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject manager = GameObject.Find(Constants.ENEMY_MANAGER);
        this.enemyManager = manager.GetComponent<EnemyManager>();
    }

    void Destroyed()
    {
        Instantiate(deathAnimation, transform.position, new Quaternion(-90, 180, 90, 0));
        this.enemyManager.AddDeathCounter();
        Destroy(this.gameObject);
    }
}
