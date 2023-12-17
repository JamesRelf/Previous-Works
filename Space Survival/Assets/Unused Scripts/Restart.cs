using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] MovingMap movingMap;
    void RestartButton()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            movingMap.SetPosition();
            RestartScene();
        }
    }
    void RestartScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    private void Update()
    {
        RestartButton();
    }

}
