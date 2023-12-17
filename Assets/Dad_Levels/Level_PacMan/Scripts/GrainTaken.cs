using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainTaken : MonoBehaviour
{
    bool isTaken;

    public bool IsTaken 
    {
        get
        {
            return isTaken;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isTaken = true;
        }
    }
}
