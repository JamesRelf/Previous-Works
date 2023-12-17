using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpLaser : PowerUpGeneric
{
    [SerializeField] Rigidbody2D bullet;
    [SerializeField] AudioManager soundEffect;
    [SerializeField] UIManager laserUI;

    GameObject fakeLaser;
    Renderer fakerLaser;

    GameObject realLaser;
    Renderer realistLaser;

    bool laserFire1;

    float bulletSpeed = 30.0f;
    float offsetX = 1.45f;
    float offsetY = 0f;

    int addBullet;

    protected override void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        fakeLaser = GameObject.FindGameObjectWithTag("Laser");
        fakerLaser = fakeLaser.GetComponent<Renderer>();

        realLaser = GameObject.FindGameObjectWithTag("LaserGame");
        realistLaser = realLaser.GetComponent<Renderer>(); 
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LaserGame")
        {
            soundEffect.AudioLaserGunPowerUp();
            laserFire1 = true;
            realistLaser.enabled = false;
        }
    }

    void Update()
    {
        FireShot();
    }
    
    void FireShot()
    {
        laserUI.DeactivateLaserPowerUp();
        fakerLaser.enabled = false;
        if (laserFire1)
        {
            if (addBullet < 999)
            {
                laserUI.ActivateLaserPowerUp();
                fakerLaser.enabled = true;

                if (Input.GetButton("Fire1"))
                {
                    soundEffect.AudioPlayerShoot();
                    Rigidbody2D shot;
                    shot = Instantiate(bullet, transform.position + new Vector3(offsetX, offsetY, 0f), transform.rotation);
                    shot.velocity = new Vector3(1.0f, 0f, 0f) * bulletSpeed;
                    addBullet++;
                }
            }
            else if (addBullet > 999)
            {
                laserFire1 = false;
            }
        }
    }
}
