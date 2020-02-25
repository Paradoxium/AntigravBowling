using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Score keeper. Place on the Canvas GameObject. Keeps track of score in the game, has public function to add point to score.
/// Updates the score text with the new score.
/// </summary>
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
