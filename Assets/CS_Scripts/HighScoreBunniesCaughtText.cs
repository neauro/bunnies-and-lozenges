using UnityEngine;
using System.Collections;

public class HighScoreBunniesCaughtText : MonoBehaviour {

	public static int score = 0;
	
	void Update () {
		score = BunnyCollect.numBunniesCaught;
		guiText.text = "Bunnies caught: " + score;
	}
}
