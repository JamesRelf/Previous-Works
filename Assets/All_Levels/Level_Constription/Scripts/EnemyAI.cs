using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    Rigidbody2D enemyRb;

    float angle;
    float moveSpeed = 1f;
    float currentTime;
    float targetTime = 10f;

    Vector2 direction;
    Vector2 movement;

    GrainTaken gt;
    public Animator anim;

    void Start()
    {
        gt = FindObjectOfType<GrainTaken>();
        enemyRb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if(gt.IsTaken == true)
        {
            StartAnim();
            CalcDir();
            CalcAngle();
            CalcMovement();
        }
    }

    void FixedUpdate()
    {
        MoveEnemy(movement);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(5);
        }
    }

    void CalcDir()
    {
        direction = player.position - transform.position;
    }

    void CalcAngle()
    {
        angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        enemyRb.rotation = angle;
    }

    void CalcMovement()
    {
        direction.Normalize();
        movement = direction;
    }

    void MoveEnemy(Vector2 dir)
    {
        enemyRb.MovePosition((Vector2)transform.position + (dir * moveSpeed * Time.deltaTime));
    }

    void StartAnim()
    {
        anim.SetBool("GrainTaken", true);
    }
}
