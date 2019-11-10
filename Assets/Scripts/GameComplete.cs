using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public GameObject victoryObject;

    public void Start()
    {
        //victoryObject.enabled = false;
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "VituvianBall")
        {
            Destroy(victoryObject);
        }
    }
}
