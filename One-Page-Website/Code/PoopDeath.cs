using UnityEngine;
using System.Collections;

public class PoopDeath : MonoBehaviour {
	public float deathtime;
	public float speed;
	public float fallSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Translate(Vector3.forward * Time.deltaTime *speed);
	transform.Translate(Vector3.up * -1 * Time.deltaTime * fallSpeed);	
	Destroy(gameObject, deathtime);
		
	}
}
