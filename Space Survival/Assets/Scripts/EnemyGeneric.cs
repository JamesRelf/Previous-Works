using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneric : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody2D enemyRigidbody;
    protected GameObject audiomanager;
    protected AudioManager soundEffect;
    float xDir = -1f;

    protected float oscillator;
    protected float timer;
    protected float amplitude = 1f;
    protected float period = 5.75f;
    protected float phase = 0f;
    protected float vshift = 0f;

    [SerializeField] float destroyTime;

    int damageAmount = 20;

    [SerializeField] protected float health;
    [SerializeField] protected int points;

    protected void Start()
    {
        audiomanager = GameObject.FindGameObjectWithTag("AudioManager");
        soundEffect = audiomanager.GetComponent<AudioManager>();

        enemyRigidbody = GetComponent<Rigidbody2D>();
        phase = Random.Range(0f, 10f);
        Invoke("DestroyObject", destroyTime);
    }

    protected void FixedUpdate()
    {
        EnemyVelocity();
    }

    protected void Update()
    {
        CalculateOscillator();
    }

    protected virtual void CalculateOscillator()
    {
        timer += Time.deltaTime;
        oscillator = (amplitude * Mathf.Sin(((2 * Mathf.PI) / period) * (timer + phase))) + vshift;
    }

    protected void EnemyVelocity()
    {
        enemyRigidbody.velocity = new Vector2(xDir * moveSpeed, oscillator);
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        DamageablePlayer damagedPlayer = collision.gameObject.GetComponent<DamageablePlayer>();

        if (damagedPlayer != null)
        {
            damagedPlayer.DealDamage(damageAmount);
        }
    }

    public virtual void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        soundEffect.AudioEnemyHit();
        if (health < 0)
        {
            soundEffect.AudioEnemyDead();
            Destroy(gameObject);
            ThePlayerManager.UpdateScore(points);
        }
    }

    protected void DestroyObject()
    {
        Destroy(gameObject);
    }
}
