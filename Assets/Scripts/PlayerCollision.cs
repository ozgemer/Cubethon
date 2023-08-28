using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public int lives = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("we hit an " + collision.collider.name);
            lives--;
        }
        if (lives == 0 || collision.collider.tag == "Finish Line") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();            
        }

    }
}
