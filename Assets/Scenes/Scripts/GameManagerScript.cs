using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public void reload_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
