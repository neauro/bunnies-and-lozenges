using UnityEngine;
using System.Collections;

public class HighScoreText : MonoBehaviour {
	
	public static int score;

	void Update () {
		score = BunnyCollect.numBunniesCaught + LozengeDefeat.numLozengesDefeated + 100 - TimerGUI.timeElapsed;
		guiText.text = "Your score: " + score;
	}
}
