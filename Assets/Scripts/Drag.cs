using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private void OnMouseDrag()
    {
        float leeway = 10;
        var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, leeway);
        var objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.localPosition = objectPosition;
    }
}
