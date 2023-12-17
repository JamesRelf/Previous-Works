using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerLocation : MonoBehaviour
{
    [SerializeField] GameObject enemySpawner;

    void Start()
    {
        SetSpawn();
    }
   
    void SetSpawn()
    {
        enemySpawner.transform.position = new Vector3(9.55f, 0f, -1f);
    }
}
