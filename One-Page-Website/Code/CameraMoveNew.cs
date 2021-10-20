using UnityEngine;
using System.Collections;

public class CameraMoveNew : MonoBehaviour {
//	public Transform Player;
	public Vector3 Offset;
	
	// Use this for initialization
	void Start () {
	
		//StartCoroutine("CL"); 
	
		}
	
	void Update() {
		GameObject Cow = GameObject.Find("Cow(Clone)");
		
		transform.position = Cow.transform.position + Offset;	
	
	}
//	public void CL(){	
	public IEnumerator CL(){	
//	public IEnumerator CL(Transform obj, Vector3 newPos){
	yield return new WaitForSeconds(0f);	
	GameObject Cow = GameObject.Find("Cow(Clone)");
		
	transform.position = Cow.transform.position + Offset;	
			
	StartCoroutine("CL");

	}
}
