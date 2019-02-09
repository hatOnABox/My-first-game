using UnityEngine;

public class BreakTheCube : MonoBehaviour
{
    bool somethingOnIt = false;
    private float timeLeft = 1.5f;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            somethingOnIt = true;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            somethingOnIt = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (somethingOnIt == true)
        {
            if (timeLeft < 0)
            {
                Destroy(gameObject);
            }
            else
            {
                timeLeft -= Time.deltaTime;
            }
        }
    }
}
