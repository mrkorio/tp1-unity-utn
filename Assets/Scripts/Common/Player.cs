using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject deathAnimation;

    void Destroyed()
    {
        Instantiate(deathAnimation, transform.position, transform.rotation);
        Invoke("GameOver", 3f);
        this.gameObject.SetActive(false);
    }

    void GameOver()
    {
        var gameObject = GameObject.Find(Constants.GAME_MANAGER);
        var manager = gameObject.GetComponent<GameManager>();
        manager.ResetCurrentLevel();
    }
}
