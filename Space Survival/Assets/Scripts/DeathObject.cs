using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObject : MonoBehaviour
{
    [SerializeField] GameObject deathScreen;
    [SerializeField] AudioManager soundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            soundEffect.AudioPlayerDead();
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
        }
    }
}
