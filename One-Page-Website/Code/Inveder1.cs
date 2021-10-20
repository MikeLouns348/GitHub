using UnityEngine;
using System.Collections;

public class Inveder1 : MonoBehaviour {
	
	public GameObject Sparks;
	public GameObject Sparks1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other) {
		if (other.name == "Ship_Bullet(Clone)")
        Destroy(gameObject);
		
		if (other.name == "Ship_Bullet(Clone)")
		Instantiate(Sparks, transform.position, Quaternion.identity);
	    if (other.name == "Ship_Bullet(Clone)")
		Instantiate(Sparks1, transform.position, Quaternion.identity);
		
//	}
//	
//	void OnDestroy(){
	
	
	
	}
}