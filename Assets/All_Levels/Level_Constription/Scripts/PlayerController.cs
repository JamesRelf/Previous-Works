using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    [SerializeField] AudioManager am;
    [SerializeField] AudioSource audioSource;

    Rigidbody2D playerRb;
    bool leftStep;
    DysenteryEffect isDead;
    
    float moveSpeed = 600f;
    
    public float MoveSpeed 
    {
        get
        {
            return moveSpeed;
        }
        set
        {
            moveSpeed = value;
        }
    }


    float horzDir;
    float vertDir;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        isDead = FindObjectOfType<DysenteryEffect>();
    }

    void Update()
    {
        CalculateDir();
        PlayerFootsteps();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void CalculateDir()
    {
        horzDir = Input.GetAxis("Horizontal") * Time.deltaTime;
        vertDir = Input.GetAxis("Vertical") * Time.deltaTime;
    }

    void MovePlayer()
    {
        playerRb.velocity = new Vector2(horzDir * moveSpeed, vertDir * moveSpeed);
        animator.SetFloat("Speed", Mathf.Abs((horzDir + vertDir) * 750));
    }

    void PlayerFootsteps()
    {
        if (isDead.IsDead)
        {
            audioSource.enabled = false;
        }
        
        if(horzDir == 0f && vertDir == 0f)
        {
            audioSource.Stop();
        }
        else
        {
            if (!audioSource.isPlaying)
            {
                if (leftStep)
                {
                    leftStep = false;
                    audioSource.clip = am.AudioFootsteps();
                    audioSource.Play();
                }
                else
                {
                    leftStep = true;
                    audioSource.clip = am.AudioFootsteps();
                    audioSource.Play();
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GrainSack")
        {
            am.AudioGrain();
        }
    }
}
