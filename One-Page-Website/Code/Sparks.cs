using UnityEngine;
using System.Collections;

public class Sparks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
	
	if (!particleSystem.IsAlive())
			Object.Destroy (gameObject, 2);
	}
			
}