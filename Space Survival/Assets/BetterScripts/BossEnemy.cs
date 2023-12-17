using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : EnemyManagers
{
    void Start()
    {
        //enemyBlueprint = gameObject;
        enemyRigidbody = GetComponent<Rigidbody2D>();
        moveSpeed = 1;
        spawnDelay = 30f;
        destroyTime = 60f;
        points = 100;
        health = 50f;
        inflictDamage = 100;
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
