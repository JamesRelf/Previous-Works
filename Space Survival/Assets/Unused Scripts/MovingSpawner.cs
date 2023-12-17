using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpawner : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] float moveSpeed;
    float xDir = 1;

    void MoveMap()
    {
        map.transform.position = new Vector3(xDir * Time.time, 0, -1);
    }

    void Update()
    {
        MoveMap();
    }
}
