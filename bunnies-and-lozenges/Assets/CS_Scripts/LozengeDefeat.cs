// handles showing how many lozenges are defeated in the GUI

using UnityEngine;
using System.Collections;

public class LozengeDefeat : MonoBehaviour {
	public static int numLozengesDefeated;
	public static int numGoalLozenges;
	
	
	void Start () {
		numLozengesDefeated = 0;
		guiText.text = "";
		numGoalLozenges = 5;
	}
	
	
	void Update () {
		if (numLozengesDefeated == 1)
			guiText.text = "you defeated a lozenge! go get more!";
		else if (numLozengesDefeated > 0)
			guiText.text = "you caught " + numLozengesDefeated + " bunnies!";
	}
}