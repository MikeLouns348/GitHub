using UnityEngine;
using System.Collections;

public class SeedShootNew : MonoBehaviour {
    
	public GameObject projectile;
	public float speed = 100;
	
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * speed);
        }
    }
}
