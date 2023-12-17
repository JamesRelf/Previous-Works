using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : EnemyGeneric
{
    public override void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        soundEffect.AudioEnemyHit();
        if (health < 0)
        {
            soundEffect.AudioBossEnemyDead();
            Destroy(gameObject);
            ThePlayerManager.UpdateScore(points);
        }
    }
}
