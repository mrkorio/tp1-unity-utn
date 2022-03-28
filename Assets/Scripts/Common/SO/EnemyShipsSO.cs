using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyShip", menuName = "Enemy Ship", order = 1)]
public class EnemyShipsSO : ScriptableObject
{
    public GameObject shipGameObject;
    public float maxHealth = 100;
    public GameObject bulletGameObject;
}
