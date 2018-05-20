using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControls : MonoBehaviour {

	public string hand        = "Left";
	public int speed_sideways = 20;
	public int speed_forwards = 1;
	public int runMultiplier  = 2;

	KeyCode leftKey;
	KeyCode rightKey;
	KeyCode runKey;

	bool running;
	int movement = 0;

	void Start(){

		bool leftHand   = hand == "Left";
		bool middleHand = hand == "Middle";
		bool rightHand  = hand == "Right";

		//left key
		if(leftHand)   leftKey = KeyCode.A;
		if(rightHand)  leftKey = KeyCode.J;
		if(middleHand) leftKey = KeyCode.F;

		//right key
		if(leftHand)   rightKey = KeyCode.D;
		if(rightHand)  rightKey = KeyCode.L;
		if(middleHand) rightKey = KeyCode.H;

		//run key
		if(leftHand)   runKey = KeyCode.LeftShift;
		if(rightHand)  runKey = KeyCode.RightShift;
		if(middleHand) runKey = KeyCode.Space;
	}

	void Update(){
		
		////////////////////////////////////////
		// INPUT LOOKUP ////////////////////////
		////////////////////////////////////////
		//check all of the necessary inputs
		bool leftCancel   = Input.GetKeyUp(leftKey);
		bool leftPressed  = Input.GetKeyDown(leftKey);
		bool rightCancel  = Input.GetKeyUp(rightKey);
		bool rightPressed = Input.GetKeyDown(rightKey);
		bool runCancel    = Input.GetKeyUp(runKey);
		bool runPressed   = Input.GetKeyDown(runKey);

		//if the signal has been given to stop - STOP FIRST.
		if(leftCancel || rightCancel) movement = 0;
			
		//otherwise start movin'!
		else if(leftPressed)  movement = -1;
		else if(rightPressed) movement = 1;

		//update running modifier separately
		if(runCancel)        running = false;
		else if (runPressed) running = true;

		//////////////////////////////////////////
		// MOVEMENT TRANSFORM ////////////////////
		//////////////////////////////////////////
		//as long as there is movement, then apply it
		if(movement != 0){
			//calculate move direction
			int multiplier  = running ? runMultiplier : 1;
			float rotation = ((speed_sideways * multiplier) * Time.deltaTime) * movement;
			transform.RotateAround(Vector3.zero, Vector3.up, rotation);
			transform.position = Vector3.MoveTowards(
				transform.position, 
				new Vector3(0,0,0), 
				((speed_forwards * multiplier) * Time.deltaTime)
			);
		}
		
	}

	void OnCollisionEnter(Collision col){
		Debug.Log("agent seen!");
	}
}
