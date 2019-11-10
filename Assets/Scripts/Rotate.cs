using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private const float Distance = 10;
    private readonly Vector3 _rotationVector = new Vector3(45, 0, 0);

    private void OnMouseDown()
    {
        if (Globals.dragEnabled) transform.Rotate(new Vector3(0, 0, 45));
    }
}
