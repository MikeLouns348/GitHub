using UnityEngine;
using System.Collections;

public class SpawnObjective : MonoBehaviour {
	
	public GameObject nextObjective;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public IEnumerator Spawn(){
		yield return new WaitForSeconds(0);
		Instantiate(nextObjective, transform.position, transform.rotation);
		
}
}
