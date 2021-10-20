using UnityEngine;
using System.Collections;

public class GretelMove : MonoBehaviour {
	
	public float moveSpeed = 0.2f;
	public float timer = 3f;
	public float timerEps = 1.5f;
	private CharacterController thisChar;
	private float defaultTimer;
	private Vector3 house;
	private Vector3 hansel;
	private Vector3 targetDir;
	private Vector3 currentDir = new Vector3(0, 0, 0);
	private bool witch = false;
	
	// Use this for initialization
	void Start () {
		house = GameObject.Find("GingerbreadHouse").transform.position;
				thisChar = GetComponent<CharacterController>();
		defaultTimer = timer;
	}
	
	// Update is called once per frame
	void Update () {
		Upkeep();
		thisChar.Move(currentDir * moveSpeed);
	}
	
	void Upkeep() {
		if (!witch) {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				ChangeDir();
				timer = Random.Range(defaultTimer - timerEps, defaultTimer + timerEps);
			}
		} else {
			hansel = GameObject.Find("Hansel").transform.position;
			currentDir = (hansel - transform.position).normalized;
		}
	}
	
	void ChangeDir() {
		targetDir = (house - transform.position).normalized;
		int sgn = Random.Range(0, 1);
		int sign = 1;
		if (sgn == 0) {
			sign = -1;
		}
		float percentOff = Random.Range(0.0f, 0.5f);
		currentDir = (sign * percentOff * transform.right) + (1 - percentOff) * targetDir;
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == "House") {
			witch = true;
		}
	}
}
