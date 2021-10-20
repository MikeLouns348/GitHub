using UnityEngine;
using System.Collections;

public class BuildingSpawn : MonoBehaviour {
	public GameObject Unit;
	public GameObject Soldier;
	public GameObject Building;
	public Vector3 Location;
	public float offsetY = 1f;
	public float offsetZ = 1f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		if (RayMovement.activeObject != null) {
			if (RayMovement.activeObject.tag == "Player" && Input.GetKeyDown(KeyCode.Mouse1) && Input.GetKey(KeyCode.B)) {
				StartCoroutine ("build");
				
			}
			
			if (RayMovement.activeObject.tag == "Building" && Input.GetKeyDown(KeyCode.Mouse1) && Input.GetKey(KeyCode.C)) {
				StartCoroutine ("spawn");
			}
			
			if (RayMovement.activeObject.tag == "Building" && Input.GetKeyDown(KeyCode.Mouse1) && Input.GetKey(KeyCode.S)) {
				StartCoroutine ("spawnSoldier");
			
			}
			
		}
	}
		
			
		public IEnumerator build(){		
			yield return new WaitForSeconds(1);
		Location = RayMovement.activeObject.position;
		Location.y += offsetY;
		Location.z += offsetZ;	
		Instantiate(Building, Location, transform.rotation);
		
		
	
	
	}
	
	public IEnumerator spawn(){		
			yield return new WaitForSeconds(1);
		foreach (Transform spawn in RayMovement.activeObject) {
			Instantiate(Unit, spawn.position, transform.rotation);
		}
	}
	
		public IEnumerator spawnSoldier(){		
			yield return new WaitForSeconds(1);
		foreach (Transform spawn in RayMovement.activeObject) {
			Instantiate(Soldier, spawn.position, transform.rotation);
//		Location.x += offset;	
//		Instantiate(Unit, Location, transform.rotation);
//		Location.x -= offset;	
//		Location.x -= offset;
//		Instantiate(Unit, Location, transform.rotation);
//		Location.
//		Location.z += offset;	
//		Instantiate(Unit, Location, transform.rotation);
//		Location.z -= offset;	
//		Location.z -= offset;	
//		Instantiate(Unit, Location, transform.rotation);
//		
//	
	
		
			
	


		}
	}
}
