using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {

	//variables
	//assign speed in inspector
	public float forwardForce = 1000f;
	public Rigidbody rb; 
	float nudgeForce = 100f;

	// Update is called once per frame
	void FixedUpdate () {

		//launch ball
		if (Input.GetKey ("space")) {
			rb.AddForce (0,0, forwardForce*Time.deltaTime);
		}
		//nudge left
		if (Input.GetKey ("a")) {
			rb.AddForce (-nudgeForce*Time.deltaTime, 0, 0);
		}
		//nudge right
		if (Input.GetKey ("d")) {
			rb.AddForce (nudgeForce*Time.deltaTime, 0, 0);
		}
		//nudge up
		if (Input.GetKey ("w")) {
			rb.AddForce (0, nudgeForce*Time.deltaTime, 0);
		}
		//nudge down
		if (Input.GetKey ("s")) {
			rb.AddForce (0, -nudgeForce*Time.deltaTime, 0);
		}

	}
}
