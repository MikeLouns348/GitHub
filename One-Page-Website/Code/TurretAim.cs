using UnityEngine;
using System.Collections;

public class TurretAim : MonoBehaviour {

	public Transform player;
	private Ray ray;
	private RaycastHit hit;
	private int i = 0;
	
	void Update () {
		transform.LookAt(player.position);
		Vector3 shootDir = player.position - transform.position;
		float shootDistance = shootDir.magnitude;
		// above refers to mspaint image
		ray = new Ray(transform.position, transform.forward);
		if (Physics.Raycast(ray, out hit)) {
			if (hit.collider.tag == "Player") {
				// print("shoot" + i.ToString());
				// i++;
				print("i see you");
			} else {
				print("are you still there?");
			}
		}		
		
		// Debug.DrawLine(ray.origin, player.position, Color.red);
		// Debug.DrawLine(ray.origin, ray.direction * shootDistance, Color.red);
	}
	
	void OnDrawGizmosSelected() {
		Gizmos.color = Color.red;
		Gizmos.DrawLine(ray.origin, ray.direction * 10);
	}
}
