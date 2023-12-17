using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpForceField : PowerUpGeneric
{
    protected GameObject player;
    GameObject forceField;
    Renderer fakeForceField;
    Collider2D playerCollider;
    [SerializeField] UIManager powerUp; 
    [SerializeField] Renderer forcesField;
    [SerializeField] AudioManager soundEffect;

    protected override void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        player = GameObject.FindGameObjectWithTag("Player");
        forceField = GameObject.FindGameObjectWithTag("ForceField");
        fakeForceField = forceField.GetComponent<Renderer>();
        playerCollider = player.GetComponent<Collider2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            Invincible();
            Invoke("NoInvincibility", 10);
            forcesField.enabled = false;
        }
    }

    void Invincible()
    {
        soundEffect.AudioInvinciblePowerUp();
        playerCollider.enabled = false;
        fakeForceField.enabled = true;
        powerUp.ActivateForceFieldPowerUp();
    }

    void NoInvincibility()
    {
        playerCollider.enabled = true;
        fakeForceField.enabled = false;
        powerUp.DeactivateForceFieldPowerUp();
    }
}
