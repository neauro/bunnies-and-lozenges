var menuSkin:GUISkin;
var areaWidth:float;
var areaHeight:float;

function OnGUI() {
	GUI.skin = menuSkin;
	var ScreenX = ((Screen.width * 0.5) - (areaWidth * 0.5));
	var ScreenY = ((Screen.height * 0.7) - (areaHeight * 0.5));
	
	GUILayout.BeginArea (Rect (ScreenX, ScreenY, areaWidth, areaHeight));
	if (GUILayout.Button("Play")) // creates and listens to mouse press
		OpenLevel("Game");
	if (GUILayout.Button("Quit"))
		Application.Quit();
	
	GUILayout.EndArea();
}

function OpenLevel(level:String) {	
	yield new WaitForSeconds(0.35);
	Application.LoadLevel(level);
}

@script RequireComponent(AudioSource)