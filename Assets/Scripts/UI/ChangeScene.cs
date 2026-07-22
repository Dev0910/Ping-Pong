using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OpenSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void OpenSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
