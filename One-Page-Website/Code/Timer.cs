using UnityEngine;
using System.Collections;

public class Timer: MonoBehaviour {
	
	

	public GameObject Ship;
	
	void Start(){
	
	Instantiate(Ship, transform.position, transform.rotation);
	
		}
		
		
	public IEnumerator Spawn(){
	yield return new WaitForSeconds(2);
		Instantiate(Ship, transform.position, transform.rotation);
		
	}
	
}
