using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    int panelToDisplay;
    PanelManager pm;

    public void Play(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }

    public void SetPanelNum(int panelNum)
    {
        pm.PanelTracker = panelNum;
    }
}
