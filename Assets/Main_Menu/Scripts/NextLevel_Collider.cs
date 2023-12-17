using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel_Collider : MonoBehaviour
{
    [SerializeField] int levelNum;
    MenuManager mm;

    void Start()
    {
        mm = FindObjectOfType<MenuManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("collided with player");
            mm.Play(levelNum);
        }
    }
}
