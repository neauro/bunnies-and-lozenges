static var bunniesCaught:int = 0;
static var allBunniesCaught:boolean = false;
static var numGoalBunnies:int;	// number of bunnies to collect to win

function Start() {
	guiText.text = "";
	numGoalBunnies = 5;
}

function Update () {
	if (bunniesCaught == 1)
		guiText.text = "you caught a bunny!  go get more!";
	else if (bunniesCaught > 0)
		guiText.text = "you caught " + bunniesCaught + " bunnies!";
	
	if (bunniesCaught == numGoalBunnies)
		allBunniesCaught = true;
}