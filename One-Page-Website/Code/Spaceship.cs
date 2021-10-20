using UnityEngine;
using System.Collections;

public class Spaceship : MonoBehaviour {
	/// <summary>
	/// Code for spaceship controls
	/// </summary>/
	
	/**********************
	 * Declare stuff here *
	 **********************/
	public float moveSpeed = 100;
	public Transform bullet;
	
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			Shoot();
		}
	}
	
	void Shoot() {
		Instantiate(bullet, transform.position, Quaternion.identity);
			
		
		
	}
}
