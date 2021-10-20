using UnityEngine;
using System.Collections;

public class PoopPS3 : MonoBehaviour {
    
	public GameObject projectile;
	public bool isPooping;

	
    void Update() {
        
		if(Input.GetButtonDown("joystick button 8")){
           Rigidbody clone;
			
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
		}
		
		
}
}



