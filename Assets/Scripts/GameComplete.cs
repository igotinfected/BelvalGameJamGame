using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public Canvas victoryCanvas;

    public void Start()
    {
        victoryCanvas.enabled = false;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "VituvianBall")
        {
            victoryCanvas.enabled = true;
        }
    }
}
