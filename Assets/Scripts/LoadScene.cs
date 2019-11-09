using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load(string sceneName)
    {
        Debug.Log("Loading scene: " + sceneName);
        SceneManager.LoadSceneAsync(sceneName, new LoadSceneParameters(LoadSceneMode.Single));
    }
}
