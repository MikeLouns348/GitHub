using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {
	public GameObject nextObjective;
	public Vector3 SpawnLocation;
	public Quaternion SpawnRotation;
	
	


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnTriggerEnter(Collider other) {
		if (other.name == "Birdseed(Clone)"){
			Instantiate(nextObjective, SpawnLocation, SpawnRotation);
      		Destroy(gameObject);
		Destroy(transform.parent.gameObject);
	

	
	
	
	}
	
	
}
}
