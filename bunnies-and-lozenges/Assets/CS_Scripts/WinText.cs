using UnityEngine;
using System.Collections;

public class WinText : MonoBehaviour {

	public static bool textOn;
	public static string message;
	private float timer;
	
	void Start () {
		timer = 0.0f;
		textOn = false;
		guiText.text = "";
	}
	
	void Update () {
		if (textOn) {
			guiText.enabled = true;
			guiText.text = message;
			timer += Time.deltaTime;
		}
		
		if (timer >= 5f) {
			textOn = false;
			guiText.enabled = false;
			timer = 0.0f;
		}
	}
}