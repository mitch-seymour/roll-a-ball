using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame, after all items have been processed in Update()
	void LateUpdate () {
		// as we move our player with the keyboard, move the camera in a new position
		// relative to the player's position
		transform.position = player.transform.position + offset;
	}
}
