using UnityEngine.SceneManagement;
using UnityEngine;

public class winLevel : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            //FindObjectOfType<GameManagerScript>().reload_game();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }
}
