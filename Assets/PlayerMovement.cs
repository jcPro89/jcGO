using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody dummyRb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 10f;

    // FixedUpdate is used for physics updates
    void FixedUpdate()
    {
        dummyRb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            dummyRb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // VelocityChange ignores mass and makes the movement more responsive
        }
        else if (Input.GetKey(KeyCode.A))
        {
            dummyRb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            dummyRb.AddForce(0, 100 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dummyRb.AddForce(0, -100 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
