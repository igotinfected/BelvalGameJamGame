﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public GameObject victoryObject;
    public Canvas victoryCanvas;

    public void Start()
    {
        victoryObject.SetActive(false);
        victoryCanvas.enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "VituvianBall")
        {
            victoryObject.SetActive(true);
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            victoryCanvas.enabled = true;
        }
    }
}
