using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    int damageAmount = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageablePlayer damagedPlayer = collision.gameObject.GetComponent<DamageablePlayer>();

        if (damagedPlayer != null)
        {
            damagedPlayer.DealDamage(damageAmount);
        }
    }

}
