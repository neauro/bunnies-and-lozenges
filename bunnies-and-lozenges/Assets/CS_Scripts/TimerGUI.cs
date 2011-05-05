// handles showing time elapsed during play

using UnityEngine;
using System.Collections;

public class TimerGUI : MonoBehaviour {

	public static int timeElapsed;

	void Start() {
		timeElapsed = 0;
	}
	
	void Update() {
		if (!BunnyCollect.allBunniesCaught) {
			timeElapsed = (int) Time.time;
			guiText.text = "Time elapsed: " + timeFormat(timeElapsed) + " seconds";
		}
	}
	
	public static string timeFormat(float time) {
		int minutes = (int)(time / 60);
		int seconds = (int)(time % 60);
		return minutes + ":" + seconds;
	}

}
