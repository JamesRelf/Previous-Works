using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damageAmount = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyGeneric damagedObject = collision.gameObject.GetComponent<EnemyGeneric>();
        
        if(damagedObject != null)
        {
            damagedObject.DealDamage(damageAmount);
            Destroy(gameObject);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
