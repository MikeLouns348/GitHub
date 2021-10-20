using UnityEngine;
using System.Collections;

public class Spawner: MonoBehaviour {

public GameObject Guy;
	
	void Start(){
		StartCoroutine("Spawn"); 
	
		}
		
		
	IEnumerator Spawn(){
	yield return new WaitForSeconds(5);
		Instantiate(Guy, transform.position, transform.rotation);
//		StartCoroutine("Spawn");

	}
}
