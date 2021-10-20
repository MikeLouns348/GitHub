using UnityEngine;
using System.Collections;

public class ShootNew : MonoBehaviour {

public GameObject bullet;
public AudioClip sound;	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButtonDown(0)){
			audio.Play();
			Shoot();
	
		}
		
	}
		
	void Shoot() {
		Instantiate (bullet, transform.position, transform.rotation);
			
		
		
	}
	
	void OnTriggerEnter(Collider other) {
//		if (other.name == "Probe(Clone)")
			Destroy(gameObject);
		
	}		
	
	
}		