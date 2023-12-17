using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] int playerGrain = 2;
    [SerializeField] TextMeshProUGUI grainCount;

    public int PlayerGrain
    {
        get
        {
            return playerGrain;
        }
        set
        {
            playerGrain = value;
        }
    }

    void Update()
    {
        SetGrainCount();
    }
    void SetGrainCount()
    {
        grainCount.text = "Grain: " + playerGrain.ToString();
    }
}
