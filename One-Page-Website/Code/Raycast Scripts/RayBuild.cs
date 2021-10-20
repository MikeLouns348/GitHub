using UnityEngine;
using System.Collections;

public class RayBuild : MonoBehaviour {

public Ray ray;	
public RaycastHit hit;	
public float speed = 1f;
public Vector3 newPoint;
public float offset = 1f;
public GameObject Guy;	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonUp(0)){
			Build();
		}
			
			if (Input.GetMouseButtonUp(1)){
			Fire();
		
		
	}
	
}	
	
	void Build(){
	//	movCheck = false;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if (Physics.Raycast(ray, out hit)){
//		print(hit.collider.gameObject.tag);
			
		if (hit.collider.gameObject.tag == "floor"){
//			print("hit");
			newPoint = hit.point;
			newPoint.y += offset;
			transform.position = newPoint;	
			Instantiate (Guy, transform.position, transform.rotation);		
		}
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