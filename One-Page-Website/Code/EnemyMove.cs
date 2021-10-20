using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	
	public float speed;
	public bool movingRight;
	public bool movingLeft;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  
		
		if (movingRight)
		{
			MoveRight();
		}
		if (movingLeft)
		{
			MoveLeft();
		}	
		
		
		if (transform.position.x > 480f){
			movingLeft = true;
			movingRight = false;
		}
		
		if (transform.position.x < 1f){
			movingLeft = false;
			movingRight = true;
		}

	}
		
	void MoveLeft(){
			transform.Translate(Time.deltaTime * -speed, 0,0);
		}
	void MoveRight(){
		transform.Translate(Time.deltaTime * speed, 0,0);
	
		}
		
	void SpeedIncrease(){
		speed += 1f;
		
	}
	}
			

		
			

