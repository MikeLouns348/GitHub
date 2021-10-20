using UnityEngine;
using System.Collections;

public class Detector : MonoBehaviour {
	
	public NPCBehaviour npc;
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			npc.target = other.transform;
		}
	}
	
	void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			npc.target = null;
		}
	}
	
}
