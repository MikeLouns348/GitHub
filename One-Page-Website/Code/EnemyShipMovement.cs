using UnityEngine;
using System.Collections;

public class EnemyShipMovement : MonoBehaviour {
	public Vector3 StartPosition;
	public Vector3 EndPosition;
	public CharacterController control;
	public float speed;
	//public GameObject gameMaster;
	
	void Start(){
//	
		 transform.Translate(Vector3.forward * Time.deltaTime);

	}
	
	//void OnDestroy(){
	//	gameMaster.GetComponent<Text>().addScore();
	//	gameMaster.GetComponent<Text2>().addScore();
	//}
	
}
