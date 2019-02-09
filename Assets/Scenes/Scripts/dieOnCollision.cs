using UnityEngine;

public class dieOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.name == "Player")
        {
            FindObjectOfType<GameManagerS>().reload_game();
        }
    }
}
