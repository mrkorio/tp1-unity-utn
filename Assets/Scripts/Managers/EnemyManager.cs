using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private int deathCount = 0;

    public void AddDeathCounter(int amount = 1) => this.deathCount += amount;

    public int GetCurrentCount() => this.deathCount;
}
