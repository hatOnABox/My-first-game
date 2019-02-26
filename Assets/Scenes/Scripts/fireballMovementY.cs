using UnityEngine;

public class fireballMovementY : MonoBehaviour
{
    public float movementSpeed = 20f;
    public Rigidbody rbFire;


    // makes the fireball able to move back and forward
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle" || collision.collider.tag == "willSendBackBreaking" || collision.collider.tag == "Finish" || collision.collider.tag == "invis")
        {
            if (movementSpeed == 20f)
            {
                movementSpeed = -20f;
            }
            else
            {
                movementSpeed = 20f;
            }

        }

        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<GameManagerScript>().reload_game();
        }
    }

    // move the fireball
    void Update()
    {
        rbFire.AddForce(0, movementSpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
}
