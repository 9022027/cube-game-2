using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMove movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        // Check if the player collides with another object
        // when the player collides with the obstacle it stops moving
        if (collisionInfo.gameObject.CompareTag("Obstacle"))
        {
            movement.enabled = false;  
        }
    }
}