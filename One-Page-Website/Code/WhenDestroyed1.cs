using UnityEngine;
using System.Collections;

public class WhenDestroyed1 : MonoBehaviour {
	
	public Vector3 SpawnLocation;
	public GameObject nextObjective;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	void OnDestroy(){
		Instantiate(nextObjective, SpawnLocation, transform.rotation);
}
}