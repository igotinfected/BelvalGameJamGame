using UnityEngine;

public class Drag : MonoBehaviour
{
    private const float Distance = 10;

    private void OnMouseDrag()
    {
        var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Distance);
        var objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.localPosition = objectPosition;
    }
}
