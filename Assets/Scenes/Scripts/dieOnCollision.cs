using UnityEngine;

public class dieOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<GameManagerS>().reload_game();
        }
    }
}
