using UnityEngine;
using System.Collections;

public class Poop : MonoBehaviour {
    
	public Vector3 endPoint;
	public bool targeted;
	public GameObject projectile;
	public GameObject seeker;
	public bool isPooping;
	public GameObject bird;
	public Vector3 startPosition;
	public Vector3 endPosition;
	
    void Update() {
		
		bird = GameObject.FindGameObjectWithTag("Player");
		
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit, 400)){
	
		
		if (hit.collider.gameObject.tag == "enemy"){
			targeted = true;
			endPoint = hit.point;
			print ("hit");	
				
			}else
				
			targeted = false;
			
				
		if ((Input.GetAxisRaw("3rd axis")< -0.3f) && !isPooping){
            StartCoroutine("Bomb");
			isPooping = true;
		
			}
		
		if ((Input.GetAxisRaw("3rd axis")> -0.3f) && isPooping){
			isPooping = false;
			
			}
			
			
//		if ((Input.GetAxisRaw("3rd axis")< -0.3f) && !isPooping && targeted){
//            StartCoroutine("Seek");
//			
			
			//}
			
			
	}
	}
		

	
	
    
	public IEnumerator Bomb(){
		Vector3 birdrot;
		birdrot.y = bird.transform.localEulerAngles.y;
					 
			Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation = Quaternion.Euler(0,birdrot.y,0)) as Rigidbody;
			yield return new WaitForSeconds(1);	
		
		
		}

	public IEnumerator Seek(){
		Vector3 birdrot;
		birdrot.y = bird.transform.localEulerAngles.y;
					 
			Rigidbody clone;
            clone = Instantiate(seeker, transform.position, transform.rotation = Quaternion.Euler(0,birdrot.y,0)) as Rigidbody;
			yield return new WaitForSeconds(1);	
		
		
		}	


}



