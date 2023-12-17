using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGeneric : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rigidBody;

    protected virtual void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
}
