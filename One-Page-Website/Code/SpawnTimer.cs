using UnityEngine;
using System.Collections;

public class SpawnTimer : MonoBehaviour {

public GameObject Ship;
	
	void Start(){
		StartCoroutine("Spawn"); 
	
		}
		
		
	IEnumerator Spawn(){
	yield return new WaitForSeconds(5);
		Instantiate(Ship, transform.position, transform.rotation);
		StartCoroutine("Spawn");

	}
}
