using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveSpawner : MonoBehaviour
{
    [SerializeField]
    private List<EnemyShipsSO> enemies;
    public Vector3 spawnValues;
    public float repeatRate = 1f;
    public float spawnDelay = 1f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, repeatRate);       
    }   

    private void SpawnEnemy()
    {
        // Instantiate the enemy randomly
        EnemyShipsSO enemySO = enemies[Random.Range(0, enemies.Count)];
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        GameObject enemyShipGameObject = Instantiate(enemySO.shipGameObject, spawnPosition, Quaternion.identity);
        enemyShipGameObject.GetComponent<Health>().SetInitialValues(enemySO.maxHealth);
        enemyShipGameObject.GetComponent<AutomaticShooter>().SetInitialValue(enemySO.bulletGameObject);
    }
}
