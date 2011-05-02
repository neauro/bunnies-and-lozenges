static var numLozengesDefeated:int = 0;
static var numGoalLozenges:int;	// number of bunnies to collect to win

function Start() {
	guiText.text = "";
	numGoalLozenges = 5;
}

function Update () {
	if (numLozengesDefeated == 1)
		guiText.text = "you defeated a lozenge!  go get more!";
	else if (numLozengesDefeated > 0)
		guiText.text = "you caught " + numLozengesDefeated + " bunnies!";
}