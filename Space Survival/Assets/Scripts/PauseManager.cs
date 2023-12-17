using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    bool paused;
    PauseManager pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = this;
    }
    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            if (paused)
            {
                pm.pausePanel.SetActive(true);
                Time.timeScale = 0f;
            }
            else 
            {
                Time.timeScale = 1f;
                pm.pausePanel.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
}
