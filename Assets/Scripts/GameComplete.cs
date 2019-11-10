using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public GameObject victoryObject;
    public Canvas victoryCanvas;
    public Animator VictoryAnimator;

    public void Start()
    {
        victoryObject.SetActive(false);
        victoryCanvas.enabled = false;
        //VictoryAnimator = GameObject.Find("mona-background-new").GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "VituvianBall")
        {
            victoryObject.SetActive(true);
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            if (victoryCanvas != null) 
                victoryCanvas.enabled = true;
            VictoryAnimator.SetTrigger("clap");
        }
    }
}