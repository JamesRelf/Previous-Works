using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] GameObject[] powerUps;
    float spawnYMin = 1f;
    float spawnYMax = -1f;
    float spawnHeight = 3f;

    void Start()
    {
        InvokeRepeating("SpawnPowerUp", 5f, 30f);
    }


    void SpawnPowerUp()
    {
        float spawnY = Random.Range(spawnYMin, spawnYMax) * spawnHeight;
        GameObject powerUp;
        powerUp = Instantiate(powerUps[0], transform.position + new Vector3(0f, spawnY, 0f), transform.rotation);

    }
}
