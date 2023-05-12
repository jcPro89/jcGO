using UnityEngine;

public class RunnerCollision : MonoBehaviour {

	public RunnerMovement movement;

	void OnCollisionEnter(Collision collisionInfo)
	{
		string colliderTag = collisionInfo.collider.tag;

		if(colliderTag.Equals("Obstacle"))
		{
			movement.enabled = false;
		}


	}
}