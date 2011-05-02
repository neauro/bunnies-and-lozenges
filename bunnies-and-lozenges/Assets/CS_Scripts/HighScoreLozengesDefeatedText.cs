using UnityEngine;
using System.Collections;

public class HighScoreLozengesDefeatedText : MonoBehaviour {
	public static int score = 0;
	
	void Update () {
		score = LozengeDefeat.numLozengesDefeated;
		guiText.text = "Lozenges Defeated: " + score;
	}
}