using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public List<GameObject> transScreenPanels = new List<GameObject>();

    public int panelTracker;

    public int PanelTracker 
    {
        get
        {
            return panelTracker;
        }
        set
        {
            panelTracker = value;
        }
    }

    void SetPanelActive()
    {
        transScreenPanels[panelTracker].SetActive(true); 
    }
    //void DeactivatePanel()
    //{
    //    transScreenPanels[panelTracker - 1].SetActive(false);
    //}

    void Update()
    {
        //panelTracker = FindObjectOfType<MenuManager>().panelToDisplay;

        SetPanelActive();
        //DeactivatePanel();
    }
}
