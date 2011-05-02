static var score:int;

function Update () {
	score = LozengeDefeat.numLozengesDefeated;
	guiText.text = "Lozenges Defeated: " + score;
}