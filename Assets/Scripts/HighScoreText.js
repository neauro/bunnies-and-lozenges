static var score:int;

function Update () {
	score = BunnyCollect.bunniesCaught + LozengeDefeat.numLozengesDefeated + 100 - TimerGUI.timeElapsed;
	guiText.text = "Your score: " + score;
}