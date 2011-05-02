static var score:int;

function Update () {
	score = BunnyCollect.bunniesCaught;
	guiText.text = "Bunnies caught: " + score;
}