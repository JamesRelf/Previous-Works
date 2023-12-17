using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grayscale : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    public void SetGrayscale(float amount)
    {
        spriteRenderer.material.SetFloat("_GrayscaleAmount", amount);
    }
}
