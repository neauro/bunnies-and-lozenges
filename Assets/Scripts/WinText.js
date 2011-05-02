static var textOn:boolean;
static var message:String;
private var timer:float = 0.0;

function Start() {
	timer = 0.0;
	textOn = false;
	guiText.text = "";
}

function Update () {
	if (textOn) {
		guiText.enabled = true;
		guiText.text = message;
		timer += Time.deltaTime;
	}
	
	if (timer >= 5) {
		textOn = false;
		guiText.enabled = false;
		timer = 0.0;
	}
}