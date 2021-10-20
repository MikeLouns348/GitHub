using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour

{
	public int speed = 100;

	
	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		Destroy(gameObject, 2);
		
	
		transform.Translate(Vector3.forward * Time.deltaTime *speed);

	
	
	
	}
}