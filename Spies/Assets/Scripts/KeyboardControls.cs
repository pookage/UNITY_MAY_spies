using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControls : MonoBehaviour {

	public string hand;

	KeyCode leftKey;
	KeyCode rightKey;
	KeyCode runKey;

	bool running;

	int movement = 0;
	int runspeed = 2;
	int speed    = 20;

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
		if(leftCancel || rightCancel) Move(0);
			
		//otherwise start movin'!
		else if(leftPressed)  Move(+1);
		else if(rightPressed) Move(-1);

		//update running modifier
		if(runCancel)        running = false;
		else if (runPressed) running = true;

		//////////////////////////////////////////
		// MOVEMENT TRANSFORM ////////////////////
		//////////////////////////////////////////
		//as long as there is movement, then apply it
		if(movement != 0){
			// Vector3 currentPosition = transform.position;
			// Vector3 nextPosition    = currentPosition + (speed * movement);
			// transform.position      = nextPosition;
			int multiplier  = running ? runspeed : 1;
			float direction = ((speed * multiplier) * Time.deltaTime) * movement;

			Debug.Log("speed : " + (speed * multiplier) + running);

			transform.RotateAround(Vector3.zero, Vector3.up, direction);
		}
		
	}

	void Move(int direction){
		movement = direction;
	}
}
