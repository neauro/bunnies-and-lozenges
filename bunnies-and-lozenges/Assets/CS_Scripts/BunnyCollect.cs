// handles display of how many bunnies are caught,
// and data concerning whether all bunnies have been caught

using UnityEngine;
using System.Collections;


public class BunnyCollect : MonoBehaviour {
	
	public static int numBunniesCaught;
	public static bool allBunniesCaught;
	public static int numGoalBunnies;
	public static int numBunniesTotal;
	
	void Start () {
		numBunniesCaught = 0;
		allBunniesCaught = false;
		guiText.text = "";
		numBunniesTotal = (GameObject.FindGameObjectsWithTag("bunny")).Length;
		
		// todo: get a better measurement for number of bunnies to catch
		numGoalBunnies = (int) numBunniesTotal / 2; // find at least half the bunnies
		//Debug.Log("total number of bunnies to catch: " + numGoalBunnies);
	}
	
	void Update () {
		if (numBunniesCaught == numGoalBunnies)
			allBunniesCaught = true;
		else {
			if (numBunniesCaught == 1)
				guiText.text = "you caught a bunny!  go get more!";
			else if (numBunniesCaught > 1)
				guiText.text = "you caught " + numBunniesCaught + " bunnies!";
		}
	}
}