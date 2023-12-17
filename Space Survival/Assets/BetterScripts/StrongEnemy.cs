using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : EnemyManagers
{
    void Start()
    {
        //enemyBlueprint = gameObject;
        enemyRigidbody = GetComponent<Rigidbody2D>();
        moveSpeed = 2;
        spawnDelay = 10f;
        destroyTime = 20f;
        points = 10;
        health = 15f;
        inflictDamage = 30;
        Invoke("DestroyObject", destroyTime);
    }

    void Update()
    {
        SpawnConditions();
    }

    public override void SpawnEnemy()
    {
        float spawnY = Random.Range(spawnYMin, spawnYMax) * spawnHeight;
        GameObject enemy;
        enemy = Instantiate(enemyBlueprint, transform.position + new Vector3(0f, spawnY, 0f), transform.rotation);
    }

    void FixedUpdate()
    {
        EnemySpriteMover();
    }
}
