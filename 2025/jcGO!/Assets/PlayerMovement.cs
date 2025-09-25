using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody dummyRb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 10f;

    void Start()
    {

    }

    // FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
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
