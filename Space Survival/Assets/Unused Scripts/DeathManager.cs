using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] GameObject deathScreen;
    bool playerAlive;
    public void Start()
    {
        playerAlive = true;
    }
    public void OnPlayerDeath(bool alive)
    {
        playerAlive = alive;
        if (playerAlive)
        {
            deathScreen.SetActive(false);
        }
        else 
        {
            deathScreen.SetActive(true);
        }
    }

 
    void Update()
    {
        
    }
}
