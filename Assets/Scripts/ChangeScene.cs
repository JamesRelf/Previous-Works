using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadLevel_1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel_2()
    {
        SceneManager.LoadScene(2);
    }
}
