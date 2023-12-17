using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] AudioManager soundEffect;
    [SerializeField] Rigidbody2D bullet;
    float bulletSpeed = 10.0f;
    float offsetX = 1.45f;
    float offsetY = 0f;

    public virtual void FireWeapon()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireShot();
        }
    }

    protected void FireShot()
    {
        soundEffect.AudioPlayerShoot();
        Rigidbody2D shot;
        shot = Instantiate(bullet, transform.position + new Vector3(offsetX, offsetY, 0f), transform.rotation);
        shot.velocity = new Vector3(1.0f, 0f, 0f) * bulletSpeed;
    }
    
    void Update()
    {
        FireWeapon();
    }
}
