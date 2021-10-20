using UnityEngine;
using System.Collections;

public class GingerbreadHouse : MonoBehaviour {
	
	public GameObject witch;
	public float timer = 3;
	private bool activated = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (activated) {
			timer -= Time.deltaTime;
		}
		
		if (timer <= 0) {
			
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == "Gretel") {
			Instantiate(witch, transform.position, Quaternion.identity);
		}
	}
}
