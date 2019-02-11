using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public void change()
    {
        SceneManager.LoadScene(sceneName);
    }
}
