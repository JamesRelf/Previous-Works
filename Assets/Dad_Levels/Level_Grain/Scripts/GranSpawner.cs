using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranSpawner : MonoBehaviour
{
    [SerializeField] GameObject grain;

    Rigidbody2D spawnerRb;
    float moveSpace = 6.5f;
    float VertDir;

    float oscillator;
    float timer;
    float amplitude = 10f;
    float period = 0.95f;
    float phase = 0f;
    float vshift = 0f;

    float initialTime = 0f;
    float spawnRate = 0.05f;

    void Start()
    {
        spawnerRb = GetComponent<Rigidbody2D>();

        InvokeRepeating("SpawnGrain", initialTime, spawnRate);
    }

    void Update()
    {
        CalculateOscillator();
    }

    void FixedUpdate()
    {
        MoveSpawner();
    }

    void CalculateOscillator()
    {
        timer += Time.deltaTime;
        oscillator = (amplitude * Mathf.Sin((2 * Mathf.PI / period) * (timer + phase))) + vshift;
    }

    void MoveSpawner()
    {
        spawnerRb.velocity = new Vector2(oscillator * moveSpace, VertDir);
    }

    void SpawnGrain()
    {
        Instantiate(grain, transform.position, Quaternion.identity);
    }
}
