using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageablePlayer : MonoBehaviour
{
    [SerializeField] AudioManager soundEffect;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] int maxHealth = 100;
    int currentHealth = 20;


    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void DealDamage(int damageAmount)
    {
        soundEffect.AudioPlayerHit();
        maxHealth -= damageAmount;
        ThePlayerManager.UpdateHealth(currentHealth);
        if (maxHealth <= 0)
        {
            soundEffect.AudioPlayerDead();
            Destroy(gameObject);
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }

    }

}
