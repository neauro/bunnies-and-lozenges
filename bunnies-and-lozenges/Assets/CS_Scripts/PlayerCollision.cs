using UnityEngine;
using System.Collections;

// handles interaction with bunnies and lozenges
// if enough bunnies are collected, go into high score screen
public class PlayerCollision : MonoBehaviour {

	void OnTriggerEnter(Collider collisionInfo) {
		if (collisionInfo.gameObject.tag == "bunny") {
			BunnyCollect.numBunniesCaught++;
			Destroy(collisionInfo.gameObject);
			
			if(BunnyCollect.numBunniesCaught == BunnyCollect.numGoalBunnies){
				WinText.textOn = true;
				WinText.message = "you got all 5 bunnies!  you win!";
				Wait();
				Application.LoadLevel("HighScore");
			}
		}
	}
	
	// function for waiting
	// waits 2 seconds
	IEnumerator Wait() {
		yield return new WaitForSeconds(2);
	}
}