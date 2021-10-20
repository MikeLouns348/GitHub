using UnityEngine;
using System.Collections;

public class CowMove : MonoBehaviour {
	
	public float moveSpeed = 6f;
	public float jump = 10f;
	public Vector3 moveDirection = Vector3.zero;	
    public float speed = 0.1f;
	public float gravity = 9f;
	Vector3 velocity = new Vector3(0f,0f,0f);
	public CharacterController controll;
	//	public CharacterMotor motor = gameObject.GetComponent<CharacterMotor>();
	
	void Start(){
	
				
	}
			
	void Update () {
		
	moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
	moveDirection *= moveSpeed;
	
		if (Input.GetKeyDown(KeyCode.Space) && controll.isGrounded){
		velocity.y = jump;
		
		}	
		
		if (moveDirection.sqrMagnitude > 0.01){ 
		//transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation (moveDirection), 1);
			transform.rotation = Quaternion.LookRotation(moveDirection);
		}
		
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			//transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
			//transform.Translate (transform.forward * moveSpeed * Time.deltaTime, Space.World);
			controll.Move(transform.forward * moveSpeed * Time.deltaTime);
			animation.Play("Walk");
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
//			transform.Translate(transform.forward * moveSpeed * Time.deltaTime, Space.World);
			controll.Move (transform.forward * moveSpeed *Time.deltaTime);
			animation.Play("Walk");
		}		
//	
//		
//		
	
		
			
		

velocity.y -= gravity;
controll.Move(velocity * Time.deltaTime);
		
		
//		

//		
	
	}
}
