using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControls : MonoBehaviour {

	public string hand;

	KeyCode leftKey;
	KeyCode rightKey;

	void Start(){

		bool leftHand  = hand == "Left";
		bool rightHand = hand == "Right";

		//left key
		if(leftHand)  leftKey = KeyCode.A;
		if(rightHand) leftKey = KeyCode.J;

		//right key
		if(leftHand)  rightKey = KeyCode.D;
		if(rightHand) rightKey = KeyCode.L;
	}

	void Update(){
		//if the signal has been given to stop - STOP FIRST.
		if(Input.GetKeyUp(leftKey) || Input.GetKeyUp(rightKey)){
			Stop();
		} 
		//otherwise start movin'!
		else if(Input.GetKeyDown(leftKey))    MoveLeft();
		else if(Input.GetKeyDown(rightKey))   MoveRight();

		
	}

	void MoveLeft(){
		Debug.Log("Move left");
	}

	void MoveRight(){
		Debug.Log("Move right");
	}

	void Stop(){
		Debug.Log("Stop moving");
	}

}
