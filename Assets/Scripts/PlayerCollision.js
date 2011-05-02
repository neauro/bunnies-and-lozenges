// handles interaction with bunnies and lozenges
// if enough bunnies are collected, go into high score screen

function OnTriggerEnter(collisionInfo : Collider) {
	if (collisionInfo.gameObject.tag == "bunny"){
		BunnyCollect.bunniesCaught++;
		Destroy(collisionInfo.gameObject);
		if(BunnyCollect.bunniesCaught == BunnyCollect.numGoalBunnies){
			WinText.textOn = true;
			WinText.message = "you got all 5 bunnies!  you win!";
			yield new WaitForSeconds(2);
			Application.LoadLevel("HighScore");
		}
		Debug.Log("bunny trigger!");
	}
	
	else if (collisionInfo.gameObject.tag == "lozenge"){
		LozengeDefeat.numLozengesDefeated++;
		Destroy(collisionInfo.gameObject);
		Debug.Log("lozenge was gotten by something");
	}
	
	else Debug.Log("other trigger...");
}

@script RequireComponent(AudioSource)