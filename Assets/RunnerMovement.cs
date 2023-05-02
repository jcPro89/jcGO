using UnityEngine;

public class RunnerMovement : MonoBehaviour {

	// A Rigidbody is needed to apply gravity to the game object, for example. 
	// In Unity, drag the Rigidbody object to this (look for its name in the Script section of the Inspector)
	public Rigidbody RunnerRigidbody = new Rigidbody(); 
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// Use this for initialization
	void Start () {
		Debug.Log("Game starting...");		
		}
		
	// FixedUpdate > Update() when working with physics in the inside (forces, velocity, etc.)
	void FixedUpdate () {		
		RunnerRigidbody.AddForce(0, 0, forwardForce * Time.deltaTime); // This force needs to be applied continously for our purpose

		if(Input.GetKey("d"))
		{
			RunnerRigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		}

		if(Input.GetKey("a"))
		{
			RunnerRigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		}
	}
}
