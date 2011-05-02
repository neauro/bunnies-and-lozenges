// bunny movement

// bunny states
var isWandering:boolean = true;
var isFleeing:boolean = false;
var isResting:boolean = false;

var rotationAmount:float = 5.0;
var movementAmount:float = 0.2;

function Update () {
	//transform.Rotate(Vector3(0, rotationAmount, 0));
	if (isWandering){
		transform.Translate(Vector3(0, 0, movementAmount));
	}else if (isFleeing){
		
	}else{
	}
}