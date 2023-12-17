using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5;
    float horzDir;
    float maxX = 7.5f;

    void Update()
    {
        GetDirection();
        MovePaddle();
    }

    void GetDirection()
    {
        horzDir = Input.GetAxisRaw("Horizontal");
    }
    void MovePaddle()
    {
        
        if ((horzDir > 0 && transform.position.x < maxX) || (horzDir < 0 && transform.position.x > -maxX))
        {
            transform.position += Vector3.right * horzDir * speed * Time.deltaTime;
        }
    }


}
