using UnityEngine;
using System.Collections;

public class shootPS3 : MonoBehaviour {
	/// <summary>
	/// Code for spaceship controls
	/// </summary>/
	
	/**********************
	 * Declare stuff here *
	 **********************/
	public Transform bullet;
	public GameObject sparks;
	public GameObject sparks1;

	
//	void Update () {
//		
//		if (Input.GetAxisRaw("3rd axis")> 0.3) {
//			Shoot();
//		}
//	}
//	
//	void Shoot() {
////		Instantiate(bullet, transform.position, Quaternion.identity);
////		bullet.velocity = transform.TransformDirection(Vector3.forward * speed);
//	Rigidbody clone;
//       clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
////            clone.velocity = transform.TransformDirection(Vector3.forward * speed);		
////		
//		
////	}
////	
////	void OnTriggerEnter(Collider other) {
////		if (other.name == "Probe(Clone)")
////			Destroy(gameObject);
////		
//	}		
//	
//	
//}	
	public bool isShooting;

	
    void Update() {
        
				
		if(Input.GetButtonDown("joystick button 9")){
            Instantiate(bullet, transform.position, transform.rotation);
			
	}
	}
}
		

	
	
    
	

