using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "VituvianBall")
        {
            Debug.Log("Win!");
            SceneManager.LoadSceneAsync("Win", new LoadSceneParameters(LoadSceneMode.Additive));
        }
    }
}
