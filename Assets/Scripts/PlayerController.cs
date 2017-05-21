using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	// called on the first frame that the script is active
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// called before rendering a game
	// this is where most of our game code will go
	void Update()
	{
		
	}

	// called just before performing any physics calculations
	// this is where our physics code will go
	void FixedUpdate()
	{
		// record input from the horizontal and vertical axes via the keyboard
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0 /* don't move up at all */, moveVertical);

		// apply forces to the rigid body of the Player object
		rb.AddForce(movement * speed);
	}
}
