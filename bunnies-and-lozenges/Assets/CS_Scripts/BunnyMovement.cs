// handles AI for bunny movement

using UnityEngine;
using System.Collections;

public class BunnyMovement : MonoBehaviour {
	// states of bunny movement
	bool isWandering;
	bool isResting;
	bool isFleeing;
	
	float bunnySpeed = 0.2f;
	float bunnySpin = 2f;
	
	void Start () {
		isWandering = true;
		isResting = isFleeing = false;
	}
	
	void Update () {
		if (isWandering) {
			transform.Rotate(0.0f,bunnySpin,0.0f);
			//transform.Translate(0.0f,0.0f,bunnySpeed);
		} else if (isFleeing) {
			transform.Translate(0.0f,0.0f,bunnySpeed);
		} else if (isResting) {
			transform.Translate(0,0,0);
		}
	}
}
