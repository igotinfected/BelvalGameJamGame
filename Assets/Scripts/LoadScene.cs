using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	
	public void LoadLevelBy(int diff)
	{
		LoadLevel(Globals.currentLevel + diff);
	}
	
	public void LoadLevel(int levelNum)
	{
		Globals.currentLevel = levelNum;
		string sceneName = Globals.levelsName + Globals.currentLevel.ToString();
		Load(sceneName);
	}
	
    public void Load(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName, new LoadSceneParameters(LoadSceneMode.Single));
    }
}
