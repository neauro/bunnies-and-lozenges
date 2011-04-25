// handles showing the "you win!" message

using UnityEngine;
using System.Collections;

public class WinText : MonoBehaviour {

	public static bool textOn;
	public static string message;
	
	void Start () {
		textOn = false;
		guiText.text = "";
	}
	
	void Update () {
		if (textOn) {
			guiText.enabled = true;
			guiText.text = message;
			Wait();
		}
	}
	
	// function for waiting
	// waits 2 seconds
	IEnumerator Wait() {
		yield return new WaitForSeconds(2);
	}
}