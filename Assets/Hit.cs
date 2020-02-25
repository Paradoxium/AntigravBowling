using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Hit. Whenever a game object with Hit collides with another object one point is added using the public
/// addPoint() function in the ScoreKeeper Script.
/// </summary>
public class Hit : MonoBehaviour {

	//assign in the inspector
	public ScoreKeeper score;

	//calls the public function of the ScoreKeeper script to add point.
	void OnCollisionEnter(Collision other){
		score.addPoints ();
	}

}
