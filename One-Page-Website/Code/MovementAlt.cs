using UnityEngine;
using System.Collections;

public class MovementAlt : MonoBehaviour {
	
	public float moveSpeed;
	public Vector3 moveDirection = Vector3.zero;
	public CharacterController CharContol;
	public bool isMoving;
	public Quaternion StartPosition; 
	public Quaternion EndPosition; 
	public float rollSpeed = .1f;
	
	
	void Start(){
	
				
	}
	
	void Update () {
	
	moveDirection =new Vector3(0f, 0f, 0f);
	moveDirection = gameObject.transform.forward;
	moveDirection *= moveSpeed;
//	
	
	CharContol.Move(moveDirection);
				
	
		
	if (Input.GetAxisRaw("X axis")< -0.3) {
		 transform.Rotate (0, 1.5f, 0);	
		 isMoving = true;
		}
		
	if (Input.GetAxisRaw("X axis")> 0.3) {
		 transform.Rotate (0, -1.5f, 0);	
		 isMoving = true;
		}
		
	if (Input.GetAxisRaw("5th axis")< -0.3) {
		 transform.Rotate(-1, 0, 0);	  
			isMoving = true;
		}
			
			
			
	if (Input.GetAxisRaw("5th axis")> 0.3) {
	 transform.Rotate(1, 0, 0);	
		
		 isMoving = true;
		}
	if ((Input.GetAxisRaw("X axis")< -0.3) || (Input.GetAxisRaw("X axis")> 0.3) || (Input.GetAxisRaw("Y axis")> 0.3)  || 
		    	(Input.GetAxisRaw("Y axis")< -0.3)){	
		isMoving = false;		
	
		}
	if(Input.GetAxisRaw("Y axis")> 0.3){
			moveSpeed = .6f;
		}else{
		moveSpeed = .3f;
	}
		
	if(Input.GetAxisRaw("Y axis")< -0.3){
			moveSpeed = .1f;

	}
		
	if(!isMoving) {
	
	StartPosition = transform.rotation;
	EndPosition.eulerAngles = 	new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);

	transform.rotation = Quaternion.Lerp(StartPosition, EndPosition, rollSpeed);	
		
	
	//Vector3.Slerp(StartPosition, EndPosition, Time.deltaTime);
	//transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);		
	
	}
	}
}
	
