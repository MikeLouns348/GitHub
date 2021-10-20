using UnityEngine;
using System.Collections;

public class Witch : MonoBehaviour {
	
	public GameObject sparks;
	private Transform gretel;
	private Vector3 moveDir;
	
	// Use this for initialization
	void Start () {
		gretel = GameObject.Find("Gretel").transform;
	}
	
	// Update is called once per frame
	void Update () {
		moveDir = (gretel.position - transform.position).normalized;
		transform.Translate(moveDir * 0.2f);
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == "Bullet(Clone)")
			transform.localScale += new Vector3(0, 1F, 0);
			print ("HIT");
		
		if (transform.localScale.y >= 10f)
			Destroy(gameObject);
		
			
		if (other.name == "Gretel") {
			Destroy(other.gameObject);
		
				
		}
	}		
	void OnDestroy(){
	Instantiate(sparks, transform.position, Quaternion.identity);
      
		
	}
}		
		



