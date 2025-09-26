using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody obstacleRb;

    public float forwardForce = 2000f;
    public float lifeTime = 2f; // tiempo antes de destruirse

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        obstacleRb.AddForce(0, 0, -forwardForce * Time.deltaTime);
    }
}
