using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winLevel : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            FindObjectOfType<GameManagerS>().reload_game();
        }
    }
}
