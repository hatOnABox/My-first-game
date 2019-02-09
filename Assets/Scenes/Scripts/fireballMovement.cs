using UnityEngine;

public class fireballMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public Rigidbody rbFire;


    // makes the fireball able to move back and forward
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Player" || collision.collider.tag != "Ground")
        { 
            if (movementSpeed == 10f)
            {
                movementSpeed = -10f;
            }
            else
            {
                movementSpeed = 10f;
            }
        
        }

        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<GameManagerS>().reload_game();
        }
    }

    // move the fireball
    void Update()
    {
        rbFire.AddForce(movementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
