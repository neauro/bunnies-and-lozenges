static var timeElapsed:int;

function Start() {
	timeElapsed = 0;
}

function Update() {
	if (!BunnyCollect.allBunniesCaught) {
		timeElapsed = Time.time;
		guiText.text = "Time elapsed: " + timeFormat(timeElapsed) + " seconds";
	}
}

static function timeFormat(time: float) {
	var minutes:int = time / 60;
	var seconds:int = time % 60;
	return minutes + ":" + seconds;
}