using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedSheet : MonoBehaviour
{
    [SerializeField] AudioManager am;
    Vector3 mousePosOffset;

    float objSpeed = 0.05f;

    Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDown()
    {
        mousePosOffset = gameObject.transform.position - GetMouseWorldPosition();
        am.AudioBedSheets();
    }

    void OnMouseUp()
    {
        am.AudioPause();
    }

    void OnMouseDrag()
    {
        transform.position = (GetMouseWorldPosition() + mousePosOffset) * objSpeed;
        
    }

}
