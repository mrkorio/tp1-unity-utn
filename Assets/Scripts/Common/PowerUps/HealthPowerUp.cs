using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    public int restoreAmount = 50;

    public override void ExecutePowerUp(GameObject player)
    {
        player.GetComponent<Health>().AddHealth(restoreAmount);
    }
}
