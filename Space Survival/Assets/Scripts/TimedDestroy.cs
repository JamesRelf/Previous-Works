using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    [SerializeField] float destroyTime = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", destroyTime);
    }
    private void DestroyObject()
    {
        Destroy(gameObject);
    }


}
