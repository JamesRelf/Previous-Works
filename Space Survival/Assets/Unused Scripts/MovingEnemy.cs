using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Rigidbody2D enemyRigidbody;
    float xDir = -1f;

    float oscillator;
    float timer;
    float amplitude = 1f;
    float period = 5.75f;
    float phase = 0f;
    float vshift = 0f;

    
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
        phase = Random.Range(0f, 10f);
    }

    void FixedUpdate()
    {
        enemyRigidbody.velocity = new Vector2(xDir * moveSpeed, oscillator);
    }
    
    void Update()
    {
        CalculateOscillator();
    }
    
    void CalculateOscillator()
    {
        timer += Time.deltaTime;
        oscillator = (amplitude * Mathf.Sin(((2 * Mathf.PI) / period) * (timer + phase))) + vshift;
    }
}
