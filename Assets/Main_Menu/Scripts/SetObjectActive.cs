using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectActive : MonoBehaviour
{
    [SerializeField] GameObject mumButton;

    public void SetMumActive()
    {
        mumButton.SetActive(true);
    }
}
