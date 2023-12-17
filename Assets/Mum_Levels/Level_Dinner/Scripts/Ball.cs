using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] AudioManager am;

    Rigidbody2D ballRb;
    float maxSpeed = 750f;
    float minY = -5.5f;
    float maxMag = 18f;

    Vector2 initialForce = Vector2.up;
    Vector2 startPos = Vector2.zero;

    bool ballExists = true;


    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.AddForce(initialForce * maxSpeed);
    }

    void Update()
    {
        if(transform.position.y < minY)
        {
            transform.position = startPos;
            ballRb.velocity = Vector3.ClampMagnitude(ballRb.velocity, maxMag);
            //print(ballRb.velocity.magnitude);
        }

        if(ballRb.velocity.magnitude > maxSpeed)
        {
            ballRb.velocity = Vector3.ClampMagnitude(ballRb.velocity, maxMag);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            am.AudioChewing();
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Plate")
        {
            am.AudioFork();
        }
    }


}
