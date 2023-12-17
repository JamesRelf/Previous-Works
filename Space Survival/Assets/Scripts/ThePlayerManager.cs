using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThePlayerManager : MonoBehaviour
{
    static public int score;
    static public int health;
    public Text scoreText;
    public Text healthText;
    public static ThePlayerManager tpm;
    [SerializeField] GameObject player;
    [SerializeField] GameObject spawnPoint;
    static public GameObject deathScreen;


    static public void UpdateScore(int points)
    {
        score += points;
        tpm.scoreText.text = score.ToString();
    }

    static public void UpdateHealth(int points)
    {
        health -= points;
        tpm.healthText.text = health.ToString();
    }


    void Start()
    {
        tpm = this;
        score = 0;
        health = 0;
        UpdateHealth(-100);
    }


}
