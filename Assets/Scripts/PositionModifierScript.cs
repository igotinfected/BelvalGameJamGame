using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionModifierScript : MonoBehaviour {

	// Variables to contain Input values from arrow keys pressed
	float dirX, dirY;

	// Move speed variable which can be modified in Inspector with slider and range from 1 to 20
	[Range(1f, 20f)]
	public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Getting Input from arrow keys multiplied by moveSpeed and deltaTime
		dirX = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
		dirY = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;

		// Setting new transform position according to arrow input
		transform.position = new Vector2 (transform.position.x + dirX, transform.position.y + dirY);
	}
}
