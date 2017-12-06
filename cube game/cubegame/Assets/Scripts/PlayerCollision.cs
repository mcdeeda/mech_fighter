using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;     // A reference to PlayerMovement script

	// This function runs when you hit another object.
	void OnCollisionEnter (Collision collisionInfo)
	{
		print ("hi");
		if(collisionInfo.gameObject.name == "Ground")
		{
			movement.isGrounded = true;
		}
		// Check if the object you collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
