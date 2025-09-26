using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player has collided with an obstacle! Collision detected with: \" + collision.gameObject.name");
            PlayerMovement.enabled = false;
        }
    }
}

