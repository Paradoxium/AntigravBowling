using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	//assign text object in inspector
	public Text score;
	int points = 0;

	// Update is called once per frame
	void Update () {
		score.text = "Score : " + points.ToString ();
	}

	//public function can be used by other scripts.
	//adds one point to the score.
	public void addPoints(){
		points = points + 1;
	}
}
