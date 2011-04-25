// handles display of how many bunnies are caught,
// and data concerning whether all bunnies have been caught

using UnityEngine;
using System.Collections;


public class BunnyCollect : MonoBehaviour {
	
	public static int numBunniesCaught;
	public static bool allBunniesCaught;
	public static int numGoalBunnies;
	
	void Start () {
		numBunniesCaught = 0;
		numGoalBunnies = 5;
		allBunniesCaught = false;
		guiText.text = "";
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