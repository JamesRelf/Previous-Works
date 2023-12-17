using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grain : MonoBehaviour
{
    
    void DestroyObject()
    {
        Destroy(gameObject);
    }

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            DestroyObject();
        }
    }
}
