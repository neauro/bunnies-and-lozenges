// handles AI for bunny movement

using UnityEngine;
using System.Collections;

public class BunnyMovement : MonoBehaviour {
	// states of bunny movement
	private enum enMoveStates {wandering, fleeing, resting };
	private enMoveStates enCurrentMove = enMoveStates.wandering;
	float bunnySpeed = 0.08f;
	float bunnySpin = 0.2f;
	float bunnyVicinity = 20f;	// vicinity of bunny
	Vector3 fleeDirection;
	private float fleeStartTime; 	// amount of time bunny has been in flee state
	private float restStartTime;		// amount of time bunny has been in rest state
	
	float playerDistance;
	GameObject player;
	
	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	
	void Update () {
		// make bunny move depending on its state
		switch (enCurrentMove) {
			case enMoveStates.wandering: {
				// calculate how close bunny is to player
				// if player is too close, bunny will flee
				playerDistance = Vector3.Distance(this.transform.position,player.transform.position);
				if (playerDistance <= bunnyVicinity) {
					animation.Stop();
					transform.LookAt(player.transform); //is constrained by x, z?
					
					// decide what direction to flee -- away from the direction closer to player
					float xDist, zDist;
					xDist = this.transform.position.x - player.transform.position.x;
					zDist = this.transform.position.z - player.transform.position.z;
					if (xDist < zDist)
						fleeDirection = new Vector3(bunnySpeed, 0f, 0f);
					else
						fleeDirection = new Vector3(0f,0f,-bunnySpeed);
					
					// set time bunny started fleeing
					fleeStartTime = Time.time;
					enCurrentMove = enMoveStates.fleeing;
					animation.Play("flee");
				} else {
					if (!animation.isPlaying)
						animation.Play("idle");
				}
				break;
			}
		
			case enMoveStates.fleeing: {
				// bunny will only flee for 5 seconds
				if (Time.time - fleeStartTime >= 5) {
					enCurrentMove = enMoveStates.resting;
					restStartTime = Time.time;
					animation.Play("idle"); // does this start from beginning of idle animation?
				} else {
					// make sure bunny stays on the ground while it's fleeing
					float height = Terrain.activeTerrain.SampleHeight(transform.position)
									+ Terrain.activeTerrain.transform.position.y;
					//transform.Translate(-transform.forward);
					transform.Translate(fleeDirection);
					transform.position = new Vector3(this.transform.position.x, height, this.transform.position.z);
				}
				break;
			}
		
			case enMoveStates.resting: {
				// bunny remains still for 5 seconds
				if (Time.time - restStartTime >= 5)
					enCurrentMove = enMoveStates.wandering;
				else
					transform.Rotate(0,bunnySpin,0);
				break;
			}
		}
	}
}
