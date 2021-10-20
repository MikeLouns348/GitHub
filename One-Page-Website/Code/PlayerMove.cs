using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public int moveSpeed = 5;
	private Vector3 moveDir;

	void Update () {
		moveDir = Vector3.zero;
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
		
		transform.Translate(moveSpeed * moveDir * Time.deltaTime);
	}
}
