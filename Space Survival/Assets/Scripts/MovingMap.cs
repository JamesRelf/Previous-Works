using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMap : MonoBehaviour
{
    [SerializeField] Camera map;
    [SerializeField] GameObject startPoint;
    [SerializeField] float moveSpeed;
    float timer;
    float xDir = 1;
     
    void MoveMap()
    {
        map.transform.position = new Vector3(xDir * timer, 0, -2);
    }

    public void SetPosition()
    {
        map.transform.position = new Vector3(-0.12f, -0.32f, -2f);
    }

    void Update()
    {
        timer += Time.deltaTime;
        MoveMap();
    }
}
