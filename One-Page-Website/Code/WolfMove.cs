using UnityEngine;
using System.Collections;

public class WolfMove : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 transform.Translate(Vector3.forward * Time.deltaTime * speed);
		animation.Play("wolfwalk");
	}
}
