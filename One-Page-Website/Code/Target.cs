using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
	
	public GameObject sparks;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
//	
//	 void OnTriggerEnter(Collider other) {
//        Destroy(other.gameObject);
//		
	void OnTriggerEnter (Collider other){
		if (other.name == "Bullet(Clone)")
			
			print ("HIT");
			
//			transform.localScale += new Vector3(1F, 1F, 1F);
//		
            // Instantiate(sparks, transform.position, Quaternion.identity);
//		
	}
}
