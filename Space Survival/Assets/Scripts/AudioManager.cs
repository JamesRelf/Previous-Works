using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip playerShoot;
    [SerializeField] AudioClip playerDead;
    [SerializeField] AudioClip playerHit;
    [SerializeField] AudioClip enemyDead;
    [SerializeField] AudioClip strongEnemyDead;
    [SerializeField] AudioClip bossEnemyDead;
    [SerializeField] AudioClip bossEnemySpawn;
    [SerializeField] AudioClip enemyHit;
    [SerializeField] AudioClip powerUpInvincible;
    [SerializeField] AudioClip powerUpLaserGun;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AudioPlayerShoot()
    {
        audioSource.PlayOneShot(playerShoot, 0.1f);
    }


    public void AudioPlayerDead()
    {
        audioSource.PlayOneShot(playerDead, 0.5f);
    }

    public void AudioPlayerHit()
    {
        audioSource.PlayOneShot(playerHit, 0.5f);
    }

    public void AudioEnemyDead()
    {
        audioSource.PlayOneShot(enemyDead, 0.2f);
    }

    public void AudioEnemyHit()
    {
        audioSource.PlayOneShot(enemyHit, 0.1f);
    }

    public void AudioStrongEnemyDead()
    {
        audioSource.PlayOneShot(strongEnemyDead, 0.3f);
    }

    public void AudioBossEnemyDead()
    {
        audioSource.PlayOneShot(bossEnemyDead, 0.4f);
    }

    public void AudioBossSpawn()
    {
        audioSource.PlayOneShot(bossEnemySpawn, 0.3f);
    }

    public void AudioInvinciblePowerUp()
    {
        audioSource.PlayOneShot(powerUpInvincible, 0.4f);
    }    
    
    public void AudioLaserGunPowerUp()
    {
        audioSource.PlayOneShot(powerUpLaserGun, 0.4f);
    }
}
