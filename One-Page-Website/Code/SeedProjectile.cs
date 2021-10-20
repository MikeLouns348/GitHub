using UnityEngine;
using System.Collections;

public class SeedProjectile : MonoBehaviour {
	public int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Destroy(gameObject, 2);
		
	
	
		transform.Translate(Vector3.forward * Time.deltaTime *speed);

	
	}
}
