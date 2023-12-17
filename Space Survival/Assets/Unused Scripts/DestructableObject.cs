using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructableObject: MonoBehaviour
{
    [SerializeField] float health = 4f;
    [SerializeField] int points = 1;

    public void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        if(health < 0)
        {
            Destroy(gameObject);
            ThePlayerManager.UpdateScore(points);
        }
    }
}
