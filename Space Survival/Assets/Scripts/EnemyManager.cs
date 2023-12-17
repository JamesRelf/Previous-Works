using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] AudioManager soundEffect;
    float spawnYMin = 1f;
    float spawnYMax = -1f;
    float spawnHeight = 3f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.7f, 0.7f);
        InvokeRepeating("SpawnStrongEnemy", 10, 10);
        InvokeRepeating("SpawnBossEnemy", 30, 30);
    }


    void SpawnEnemy()
    {
        float spawnY = Random.Range(spawnYMin, spawnYMax) * spawnHeight;
        GameObject enemy;
        enemy = Instantiate(enemies[0], transform.position + new Vector3(0f, spawnY, 0f), transform.rotation);

    }
    void SpawnStrongEnemy()
    {
        GameObject enemy;
        enemy = Instantiate(enemies[1], transform.position + new Vector3(0f, 0.5f, 0f), transform.rotation);
    }
    void SpawnBossEnemy()
    {
        soundEffect.AudioBossSpawn();
        float spawnY = Random.Range(spawnYMin, spawnYMax) * spawnHeight;
        GameObject enemy;
        enemy = Instantiate(enemies[2], transform.position + new Vector3(0f, spawnY, 0f), transform.rotation);
    }
}
