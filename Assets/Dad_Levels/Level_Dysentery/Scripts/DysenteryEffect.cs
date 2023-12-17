using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DysenteryEffect : MonoBehaviour
{
    [SerializeField] float startTimeBtwSpawns = 1f;
    [SerializeField] GameObject[] poo;
    [SerializeField] float speedDeduction = 50f;
    [SerializeField] Grayscale grayscale;
    [SerializeField] AudioManager am;

    PlayerController pc;
    float zSpawnPos = 1f;
    float timeBtwSpawns;
    bool isDead = false;

    public bool IsDead
    {
        get
        {
            return isDead;
        }
    }

    void Start()
    {
        pc = GetComponent<PlayerController>();
        StartCoroutine(SlowDown());
    }

    void Update()
    {
        Excrete();

        if(pc.MoveSpeed <= 0)
        {
            isDead = true;
            am.AudioCollapse();
            grayscale.SetGrayscale(1);
            pc.MoveSpeed = 750f;
        }
    }


    void Excrete()
    {
        if (timeBtwSpawns <= 0 && !isDead)
        {
            int rand = Random.Range(0, poo.Length);
            GameObject instance = (GameObject)Instantiate(poo[rand], new Vector3(transform.position.x, transform.position.y, zSpawnPos),
                Quaternion.Euler(new Vector3(0, 0, Random.Range(45, 135))));
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

    IEnumerator SlowDown()
    {
        while (pc.MoveSpeed >= 0 && !isDead)
        {
            pc.MoveSpeed -= speedDeduction;
            yield return new WaitForSeconds(0.5f);
        }
    }


}
