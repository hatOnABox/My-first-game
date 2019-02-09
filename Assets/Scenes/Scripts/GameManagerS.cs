using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManagerS : MonoBehaviour
{
    public void reload_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
