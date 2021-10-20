using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public float moveSpeed = 10;
	public float rotateSpeed = 20;
	private Vector3 moveDir;
	private Vector3 rotateDir;

	void Update () {
		moveDir = Vector3.zero;
		rotateDir = Vector3.zero;
		
		if (Input.GetKey(KeyCode.W)) {
			moveDir += Vector3.forward;
		}
		if (Input.GetKey(KeyCode.S)) {
			moveDir += Vector3.back;
		}
		if (Input.GetKey(KeyCode.Q)) {
			moveDir += Vector3.left;
		}
		if (Input.GetKey(KeyCode.E)) {
			moveDir += Vector3.right;
		}
		if (Input.GetKey(KeyCode.A)) {
			rotateDir = Vector3.down;
		}
		if (Input.GetKey(KeyCode.D)) {
			rotateDir = Vector3.up;
		}
		
		if (moveDir.magnitude != 0 || rotateDir.magnitude != 0) {
			// animation.Play("run");
			transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
			transform.Rotate(rotateDir.normalized * rotateSpeed * Time.deltaTime);
		} else {
			// animation.Play("idle");
		}
	}
}
