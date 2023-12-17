using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel_Invoke : MonoBehaviour
{
    [SerializeField] int levelNum;
    [SerializeField] int panelNum;
    MenuManager mm;


    void Start()
    {
        mm = FindObjectOfType<MenuManager>();
        Invoke("NextLevel",5f);
    }

    void NextLevel()
    {
        mm.Play(levelNum);
    }
}
