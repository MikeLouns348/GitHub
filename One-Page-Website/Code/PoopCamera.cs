using UnityEngine;
using System.Collections;

public class PoopCamera : MonoBehaviour {
	public GameObject bird;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	bird = GameObject.FindGameObjectWithTag("Player");
		
		Vector3 birdtemp;
		Vector3 camrot;
		Vector3 birdrot;
		
		birdrot.y = bird.transform.localEulerAngles.y;
		camrot = transform.localEulerAngles;
		camrot.y = birdrot.y;
	 	transform.localEulerAngles = camrot;
		birdtemp = bird.transform.position;
		birdtemp.y = birdtemp.y -.5f;
		transform.position = birdtemp;
	}
}
