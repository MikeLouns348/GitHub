using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	/// <summary>
	/// Code for spaceship controls
	/// </summary>/
	
	/**********************
	 * Declare stuff here *
	 **********************/
	public Transform bullet;
	public GameObject sparks;
	public GameObject sparks1;
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			Shoot();
		}
	}
	
	void Shoot() {
		Instantiate(bullet, transform.position, Quaternion.identity);
			
		
		
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == "Probe(Clone)")
			Destroy(gameObject);
		
	}		
	
	
}		

