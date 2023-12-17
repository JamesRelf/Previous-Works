using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedSheet1 : MonoBehaviour
{
    Vector3 mousePosOffset;

    float objSpeed = 0.05f;

    Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDown()
    {
        mousePosOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseDrag()
    {
        transform.position = (GetMouseWorldPosition() + mousePosOffset) * objSpeed;
    }

}
