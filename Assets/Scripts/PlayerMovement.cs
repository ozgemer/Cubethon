using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwadForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    //FixedUpdate => when u want to change physics i.e: forces, velocity, etc.
    void FixedUpdate()
    {
        // Time.deltaTime => amount of seconds between frames (helps sync between different computers)
        rb.AddForce(0, 0, forwadForce * Time.deltaTime); // add a forward force
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
