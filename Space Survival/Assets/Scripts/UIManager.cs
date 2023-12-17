using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image laserPowerUp;
    [SerializeField] Image forceFieldPowerUp;

    public void ActivateLaserPowerUp()
    {
        laserPowerUp.enabled = true;
    }
    
    public void DeactivateLaserPowerUp()
    {
        laserPowerUp.enabled = false;
    }

    public void ActivateForceFieldPowerUp()
    {
        forceFieldPowerUp.enabled = true;
    }

    public void DeactivateForceFieldPowerUp()
    {
        forceFieldPowerUp.enabled = false;
    }
}
