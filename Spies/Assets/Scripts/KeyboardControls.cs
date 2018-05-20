using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControls : MonoBehaviour {

	public string hand;

	KeyCode leftKey;
	KeyCode rightKey;

	int movement = 0;
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
	}

	void Update(){
		
		////////////////////////////////////////
		// INPUT LOOKUP ////////////////////////
		////////////////////////////////////////
		//check all of the necessary inputs
		bool leftCancel   = Input.GetKeyUp(leftKey);
		bool rightCancel  = Input.GetKeyUp(rightKey);
		bool leftPressed  = Input.GetKeyDown(leftKey);
		bool rightPressed = Input.GetKeyDown(rightKey);

		//if the signal has been given to stop - STOP FIRST.
		if(leftCancel || rightCancel) Move(0);
			
		//otherwise start movin'!
		else if(leftPressed)  Move(+1);
		else if(rightPressed) Move(-1);

		//////////////////////////////////////////
		// MOVEMENT TRANSFORM ////////////////////
		//////////////////////////////////////////
		//as long as there is movement, then apply it
		if(movement != 0){
			// Vector3 currentPosition = transform.position;
			// Vector3 nextPosition    = currentPosition + (speed * movement);
			// transform.position      = nextPosition;
			float direction = (speed * Time.deltaTime) * movement;
			transform.RotateAround(Vector3.zero, Vector3.up, direction);
		}
		
	}

	void Move(int direction){
		movement = direction;
	}
}
