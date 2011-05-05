// handles showing high score information (time elapsed during play)

using UnityEngine;
using System.Collections;

public class HighScoreTimeElapsedText : MonoBehaviour {

	void Update () {
		float timeElapsed = TimerGUI.timeElapsed;
		guiText.text = "Time Elapsed: " + TimerGUI.timeFormat(timeElapsed);
	}
}
