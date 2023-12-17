using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuyFood : MonoBehaviour
{
    [SerializeField] AudioManager am;
    [SerializeField] GameObject nextLevelButton;
    PlayerMoney pm;
    int counter = 0;

    void Start()
    {
        pm = FindObjectOfType<PlayerMoney>();
    }

    public void DecreaseMoney(int cost)
    {
        if(pm.PlayerGrain == 0)
        {
            SceneManager.LoadScene(18);
        }
        else
        {
            pm.PlayerGrain -= cost;
            counter++;
            if(counter == 2)
            {
                nextLevelButton.SetActive(true);
            }
            am.AudioBuying();
        }
    }
}
