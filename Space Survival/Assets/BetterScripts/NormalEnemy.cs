using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : EnemyManagers
{
    void Start()
    {
        //enemyBlueprint = gameObject;
        enemyRigidbody = GetComponent<Rigidbody2D>();
        destroyTime = 5f;
        moveSpeed = 5;
        spawnDelay = 0.7f;
        destroyTime = 5f;
        points = 1;
        health = 1f;
        inflictDamage = 10;
        Invoke("DestroyObject", destroyTime);
    }

    public override void SpawnEnemy()
    {
        float spawnY = Random.Range(spawnYMin, spawnYMax) * spawnHeight;
        GameObject enemy;
        enemy = Instantiate(enemyBlueprint, transform.position + new Vector3(0f, spawnY, 0f), transform.rotation);
        print("enemy spawned");
    }

    void FixedUpdate()
    {
        EnemySpriteMover();
    }


}
