using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadThing : Grain
{
    [SerializeField] AudioManager am;
    PlayerController pc;

    float speedIncrease = 50f;

    void Start()
    {
        pc = FindObjectOfType<PlayerController>();
    }

    void IncreasePlayerSpeed()
    {
        pc.MoveSpeed += speedIncrease;
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        if(collision.gameObject.tag == "Player")
        {
            am.AudioChewing();
            IncreasePlayerSpeed();
        }
    }
}
