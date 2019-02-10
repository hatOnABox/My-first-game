using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public int num = 0;
    public void change()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + num);
    }
}
