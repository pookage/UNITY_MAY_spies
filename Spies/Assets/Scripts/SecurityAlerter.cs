using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityAlerter : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		Debug.Log("there's been a collision!");
	}
}
