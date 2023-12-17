using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] List<GameObject> inventory;

    void Start()
    {
        inventory = new List<GameObject>();
    }

    public void AddItem(GameObject go)
    {
        inventory.Add(go);
    }
}
