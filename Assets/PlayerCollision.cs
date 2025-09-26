using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player has collided with an obstacle!");
            PlayerMovement.enabled = false;
        }
    }
}

