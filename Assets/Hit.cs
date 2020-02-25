using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

	//assign in the inspector
	public ScoreKeeper score;

	//calls the public function of the score keeper script to add points
	void OnCollisionEnter(Collision other){
		score.addPoints ();
	}

}
