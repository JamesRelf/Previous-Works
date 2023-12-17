using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] float waitTime;

    void Awake()
    {
        button.gameObject.SetActive(false);
    }

    void Start()
    {
        Invoke("SetButtonActive", waitTime);
    }

    void SetButtonActive()
    {
        button.gameObject.SetActive(true);
    }
}
