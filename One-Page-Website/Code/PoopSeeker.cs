using UnityEngine;
using System.Collections;

public class PoopSeeker : MonoBehaviour {
	public float deathtime;
	public float speed;
	public float fallSpeed;
	public Vector3 startPosition;
	public Vector3 endPosition;
	public GameObject poopShoot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	startPosition = transform.position;
	poopShoot = GameObject.Find ("PoopCamera");
	endPosition = poopShoot.GetComponent<Poop>().endPoint; 	
	transform.position = Vector3.Lerp(startPosition, endPosition, speed);
	Destroy(gameObject, deathtime);
		
	}
}
