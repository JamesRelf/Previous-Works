using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attach : MonoBehaviour
{
    [SerializeField] AudioManager am;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.transform.SetParent(collision.transform);
            am.AudioPickup();
        }
    }


}
