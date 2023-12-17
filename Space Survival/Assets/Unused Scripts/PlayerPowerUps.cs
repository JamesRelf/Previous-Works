using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUps : MonoBehaviour
{
    [SerializeField] Collider2D _collider;
    [SerializeField] GameObject forceField;

    public void Invincible()
    {
        _collider.enabled = false;
        forceField.SetActive(true);
        print("I am called");
    }
}
