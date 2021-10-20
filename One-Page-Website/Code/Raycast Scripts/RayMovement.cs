using UnityEngine;
using System.Collections;

public class RayMovement : MonoBehaviour {

public Ray ray;	
public RaycastHit hit;	
public float speed = .5f;
public static Vector3 newPoint;
public float offset = 1f;
public static Transform activeObject;

	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButton(0)){
			MouseMove();
		}
			
			if (Input.GetMouseButton(1)){
			Fire();
		
		
	}
	
}	
	
	void MouseMove(){

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if (Physics.Raycast(ray, out hit)){

		if (hit.collider.tag == "Player"){
			activeObject = hit.transform;
				activeObject.GetComponent<Move>().isSelected = true;
				
			}
			if (hit.collider.tag=="Building") {
				activeObject = hit.transform;
			}
		}
				
		if (hit.collider.gameObject.tag == "floor"){
			newPoint = hit.point;
			newPoint.y += offset;
//			GameObject spawn = RayMovement.activeObject;
		activeObject.GetComponent<Move>().StartCoroutine("move");
//			StartCoroutine ("move");
		}
}
		
		


	
	
	
	
void Fire(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if (Physics.Raycast(ray, out hit)){
			
		if (hit.collider.gameObject.tag == "enemy"){	
			hit.collider.GetComponent<Destroy>().Kill();
			}
		}
	}
}
				
