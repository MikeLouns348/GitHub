using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
	if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
		 transform.Translate(0, 1, 0);
		
		
		}
		
	if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
		 transform.Translate(0, -1, 0);	
		
		}
	}
}
