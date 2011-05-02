using UnityEngine;
using System.Collections;

public class InstructionsMenuGUI : MonoBehaviour {
	public GUISkin menuSkin;
	public float areaWidth;
	public float areaHeight;

	void OnGUI() {
		GUI.skin = menuSkin;
		float ScreenX = ((Screen.width * 0.5f) - (areaWidth * 0.5f));
		float ScreenY = ((Screen.height * 0.7f) - (areaHeight * 0.5f));
		
		GUILayout.BeginArea (new Rect (ScreenX, ScreenY, areaWidth, areaHeight));
		if (GUILayout.Button("Play")) // creates and listens to mouse press
			OpenLevel("Game");
		if (GUILayout.Button("Quit"))
			Application.Quit();
		
		GUILayout.EndArea();
	}

	void OpenLevel(string level) {	
		Wait();
		Application.LoadLevel(level);
	}	
	
	IEnumerator Wait() {
		yield return new WaitForSeconds(0.35f);
	}
		
}
