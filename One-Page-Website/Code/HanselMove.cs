using UnityEngine;
using System.Collections;

public class HanselMove : MonoBehaviour {
	
	public float moveSpeed = 0.1f;
	public Transform bread;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(0, 0, 1);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(0, 0, -1);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-1, 0, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
		Instantiate(bread, transform.position, Quaternion.identity);
		}	
	
	}
}
