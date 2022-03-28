using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour
{
    public float crashDamage = 25;
    private static GameManager gameManager;

    // Use this for initialization
    void Start()
    {
        if (!gameManager)
            gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Note: you can optimize these by using Tags
        // ignore bullet to bullet collision
        if (this.GetComponent<Bullet>() && other.GetComponent<Bullet>())
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }

        if (this.CompareTag("Bullet") && other.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }

        // ignore collision with Enemy or Boundary or Enemy bullets
        if (other.tag == "Boundary")
            return;
        if (this.CompareTag("Enemy") && other.CompareTag("EnemyBullet"))
            return;

        if (other.CompareTag("Enemy") && this.CompareTag("EnemyBullet"))
            return;

        if (this.CompareTag("Bullet") && other.CompareTag("Player"))
            return;

        if (this.CompareTag("Bullet") && other.CompareTag("Enemy"))
        {
            Health health = other.gameObject.GetComponent<Health>();
            health.ReduceHealthByAmount(crashDamage);
            Destroy(gameObject);
        }

        if (this.CompareTag("EnemyBullet") && other.CompareTag("Player"))
        {

            Health health = other.gameObject.GetComponent<Health>();
            health.ReduceHealthByAmount(crashDamage);
            Destroy(gameObject);
        }


    }
}