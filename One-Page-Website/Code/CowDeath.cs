using UnityEngine;
using System.Collections;



public class CowDeath : MonoBehaviour {
	
	
	public GameObject gameMaster;
//	public GameObject cameraNew;
	
	// Use this for initialization
	void Start () {
		gameMaster = GameObject.Find ("Referee");
//		cameraMove = GameObject.Find ("cameraMove");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.name == "Bullet1(Clone)")
			Destroy(gameObject);
		
		if(other.name == "DeathCube")
			Destroy(gameObject);
	}
	
	void OnDestroy(){
		GameObject spawn = GameObject.Find("CowSpawn");
		spawn.GetComponent<Timer>().StartCoroutine("Spawn");
		gameMaster.GetComponent<Lives>().loselife();
		GameObject Cam = GameObject.Find("Cam");
		Cam.GetComponent<CameraMoveNew>().StartCoroutine("CL");
	}
}
