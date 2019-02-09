using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float sidewaysForce = 20f;
    bool grounded = true;

    // if player is touching the ground
    void OnCollisionEnter()
    {
        grounded = true;
    }


    // Player movement
    void FixedUpdate()
    {
        if (rb.position.y < -4)
        {
            FindObjectOfType<GameManagerS>().reload_game();
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {

            if (grounded == true) {
                rb.AddForce(0, 6, 0, ForceMode.VelocityChange);
                grounded = false;
            }
        }
    }
}
