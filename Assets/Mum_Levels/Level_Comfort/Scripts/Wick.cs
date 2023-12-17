using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wick : MonoBehaviour
{
    public GameObject button;

    bool isSnuffed = false;

    public bool IsSnuffed
    {
        get
        {
            return isSnuffed;
        }
        set
        {
            isSnuffed = value;
        }
    }

    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        StartCoroutine(DecreaseWick());
    }


    IEnumerator DecreaseWick()
    {
        while (isSnuffed == false)
        {
            slider.value -= 1;
            yield return new WaitForSeconds(1f);
        }
    } 
}
