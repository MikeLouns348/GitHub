using UnityEngine;
using System.Collections;

public class CameraParent : MonoBehaviour {
	
	public GameObject poop;
	public GameObject bird;
	public Transform birdrotation;
	public float Offset = -5f;
	
	// Use this for initialization
	void Start () {
		

		
	
	}
	
	// Update is called once per frame
	void Update () {
	//poop = GameObject.FindGameObjectWithTag("poop");
	bird = GameObject.FindGameObjectWithTag("Player");
	
	
//	if (poop != null){
//			Vector3 pooptemp;
//			pooptemp = poop.transform.position;
//			pooptemp.y = pooptemp.y +2;
//			transform.position = pooptemp;
			
//		}else
			
	//if (poop == null){
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

