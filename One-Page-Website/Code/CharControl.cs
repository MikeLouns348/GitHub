using UnityEngine;
using System.Collections;

public class CharControl : MonoBehaviour {

	///////////////////////////////
	// Character Controller demo //
	// CC - Character Controller //
	// TT - transform.Translate  //
	// RB - Rigidbody            //
	///////////////////////////////
	
	//public CharacterController charControl;								//CC
	public Vector3 moveDir;
	public float moveSpeed = 10;

	void Start () {
		//charControl = gameObject.GetComponent<CharacterController>();		//CC
	}
	
	void Update () {
		moveDir = new Vector3(0, 0, 0);
		
		if (Input.GetKey(KeyCode.W)) {
			moveDir.z = 1;
		}
		if (Input.GetKey(KeyCode.A)) {
			moveDir.x = -1;
		}
		
		if (Input.GetKey(KeyCode.S)) {
			moveDir.z = -1;
		}
		
		if (Input.GetKey(KeyCode.D)) {
			moveDir.x = 1;
		}
		
		//charControl.Move(moveDir * moveSpeed);								//CC
		//transform.Translate(moveDir * moveSpeed);								//TT
		//rigidbody.AddForce(moveDir * moveSpeed);								//RB
	}
}
