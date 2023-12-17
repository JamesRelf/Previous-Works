using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStrong : EnemyGeneric
{

    public override void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        soundEffect.AudioEnemyHit();
        if (health < 0)
        {
            soundEffect.AudioStrongEnemyDead();
            Destroy(gameObject);
            ThePlayerManager.UpdateScore(points);
        }
    }

    protected override void CalculateOscillator()
    {
        amplitude = 8f;
        period = 2f;
        timer += Time.deltaTime;
        oscillator = (amplitude * Mathf.Sin(((2 * Mathf.PI) / period) * (timer + phase))) + vshift;
    }
}
