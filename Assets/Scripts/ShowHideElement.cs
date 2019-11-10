using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideElement : MonoBehaviour
{

    public void ToggleVisibility(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

}
