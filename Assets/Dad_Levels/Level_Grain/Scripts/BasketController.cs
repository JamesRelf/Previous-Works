using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketController : MonoBehaviour
{
    Rigidbody2D basketRb;
    float moveSpeed = 900f;
    float horzDir;
    float vertDir;

    [SerializeField] float score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] AudioManager am;

    void Start()
    {
        basketRb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        CalculateHorizontal();

        if(score >= 3)
        {
            score = 2;
        }
        scoreText.text = score.ToString();
    }

    private void FixedUpdate()
    {
        MoveBasket();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Grain")
        {
            am.AudioGrain();
            score++;
        }
    }

    void CalculateHorizontal()
    {
        horzDir = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
    }

    void MoveBasket()
    {
        basketRb.velocity = new Vector2(horzDir * moveSpeed, vertDir);
    }
}
