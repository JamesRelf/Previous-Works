using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopBurning : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AudioManager am;
    Wick wick;

    void Start()
    {
        wick = FindObjectOfType<Wick>();
        am.AudioCandle();
        animator.SetFloat("Speed", 1f);
    }

    public void SnuffFlame()
    {
        wick.IsSnuffed = true;
        wick.button.SetActive(false);
        
        if (wick.IsSnuffed)
        {
            am.AudioStop();
            am.AudioSnuff();
            Invoke("LoadNextScene", 1.5f);
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(14);
    }
}
