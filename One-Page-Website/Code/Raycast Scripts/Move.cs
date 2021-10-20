using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public float speed = 1f;
	public bool isSelected = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator move(){	
	yield return 0;	
	float timer = 0;
//		
//		if (RayMovement.activeObject.tag == "Player")		
	
		while (timer < 1 && isSelected){
		transform.position = Vector3.Lerp (transform.position, RayMovement.newPoint, Time.deltaTime * speed);
		timer += Time.deltaTime;
		yield return 0;
		}
	}

}
