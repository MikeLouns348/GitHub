using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	public float moveSpeed = 100;
			
	
	void Start(){
		
				
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow) ||  Input.GetKey(KeyCode.A)) {
			transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
		}
				
	
	}
}