using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagers : MonoBehaviour
{
    [SerializeField] protected GameObject enemyBlueprint;

    protected float health;
    protected int points;

    protected float destroyTime;

    protected int inflictDamage;

    protected float spawnTimer = 0f;
    protected float spawnDelay;
    protected float spawnYMin = 1f;
    protected float spawnYMax = -1f;
    protected float spawnHeight = 3f;

    protected float moveSpeed;
    protected Rigidbody2D enemyRigidbody;
    protected float xDir = -1f;

    protected float oscillator;
    protected float timer;
    protected float amplitude = 1f;
    protected float period = 5.75f;
    protected float phase = 0f;
    protected float vshift = 0f;

    void Start()
    {
        
        phase = Random.Range(0f, 10f);
        //Invoke("DestroyObject", destroyTime);
    }
   
    void Update()
    {
        CalculateOscillator();
        SpawnConditions();
    }

    void FixedUpdate()
    {
        //EnemySpriteMover();
    }
   
    protected void SpawnConditions()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnDelay)
        {
            SpawnEnemy();
            spawnTimer = 0f;
            print("enemy spawned");
        }
    }
    
    public virtual void SpawnEnemy()
    {
        float spawnY = Random.Range(spawnYMin, spawnYMax) * spawnHeight;
        GameObject enemy;
        enemy = Instantiate(enemyBlueprint, transform.position + new Vector3(0f, spawnY, 0f), transform.rotation);
    }

    public void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0)
        {
            Destroy(gameObject);
            ThePlayerManager.UpdateScore(points);
        }
    }

    protected void DestroyObject()
    {
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        DamageablePlayer damagedPlayer = collision.gameObject.GetComponent<DamageablePlayer>();

        if (damagedPlayer != null)
        {
            damagedPlayer.DealDamage(inflictDamage);
        }

    }
    
    protected void CalculateOscillator()
    {
        timer += Time.deltaTime;
        oscillator = (amplitude * Mathf.Sin(((2 * Mathf.PI) / period) * (timer + phase))) + vshift;
    }

    protected void EnemySpriteMover()
    {
        enemyRigidbody.velocity = new Vector2(xDir * moveSpeed, oscillator);
    }
}
