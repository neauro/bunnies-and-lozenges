// handles collision interaction between player
// and objects in environment

using UnityEngine;
using System.Collections;

// handles interaction with bunnies and lozenges
// if enough bunnies are collected, go into high score screen
public class PlayerCollision : MonoBehaviour {

	void OnTriggerEnter(Collider collisionInfo) {
		if (collisionInfo.gameObject.tag == "bunny") {
			BunnyCollect.numBunniesCaught++;
			Destroy(collisionInfo.gameObject);
			
			// todo: make it so that player only has to catch numGoalBunnies amount of bunnies
			//		 instead of all bunnies, but can continue catching more bunnies
			//if(BunnyCollect.numBunniesCaught == BunnyCollect.numGoalBunnies){
			if(BunnyCollect.numBunniesCaught == BunnyCollect.numBunniesTotal){
				WinText.textOn = true;
				WinText.message = "you got all bunnies!  you win!";
				Wait();
				Application.LoadLevel("HighScore");
			}
			
		} else if (collisionInfo.gameObject.tag == "lozenge") {
			LozengeDefeat.numLozengesDefeated++;
			Destroy(collisionInfo.gameObject);
		}
		
		
	}
	
	// function for waiting
	// waits 2 seconds
	IEnumerator Wait() {
		yield return new WaitForSeconds(2f);
	}
}