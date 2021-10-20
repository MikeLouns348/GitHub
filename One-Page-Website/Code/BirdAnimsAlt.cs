using UnityEngine;
using System.Collections;

public class BirdAnimsAlt: MonoBehaviour {
	
	public Quaternion StartPosition;

	public Quaternion EndPosition; 
	public float rollSpeed = .1f;
	public bool isMovingLeft;
	public bool isMovingRight;
	public bool isSpeeding;
	private float axisInput;
	private string currentAxis;
	public float FadeSpeed;

	// Use this for initialization
	void Start () {
		animation.Play("fly");
	
	}
	
//	void Awake(){
//	animation("fly").layer = 0;
//		animation("BankLeft").layer = 1;
//		animation("BankRight").layer = 2;
//		animation("BankLeft").blendMode = AnimationBlendMode.Blend;
//		animation("Bankright").blendMode = AnimationBlendMode.Blend;
//	
	//}
	
	// Update is called once per frame
	void Update () {
		
	// this section is used for debugging and reading the values of the axis
		
		if(Input.GetAxisRaw("5th axis")> 0.3|| Input.GetAxisRaw("5th axis") < -0.3){
			currentAxis = "5th axis";
			axisInput = Input.GetAxisRaw("5th axis");
			
			}
		
		
		if(Input.GetAxisRaw("Y axis")> 0.3|| Input.GetAxisRaw("Y axis") < -0.3){
			currentAxis = "Y axis";
			axisInput = Input.GetAxisRaw("Y axis");
		}
		
				if(Input.GetAxisRaw("X axis")> 0.3|| Input.GetAxisRaw("X axis") < -0.3){
			currentAxis = "X axis";
			axisInput = Input.GetAxisRaw("X axis");
		}
	
		//these are the animation triggers
		
		if ((Input.GetAxisRaw("Y axis")> 0.99f) && !isSpeeding){
			animation.Play("flap");
			//animation("BankdRight") = AnimationBlendMode.Additive;
			isSpeeding = true;
		}
		
		if ((Input.GetAxisRaw("X axis")< -0.99f) && !isMovingRight){
			animation.Blend("BankRight", 1f, 0f);
			//animation("BankdRight") = AnimationBlendMode.Additive;
			isMovingRight = true;
		}
	

		
		
	if ((Input.GetAxisRaw("X axis")> 0.99f) && !isMovingLeft){ 
		animation.Blend("BankLeft", 1f, 0f);
		//animation("BankdLeft")= AnimationBlendMode.Additive;
			isMovingLeft = true;
			}
		
		

		
	if ((Input.GetAxisRaw("X axis")> -0.9f) && (Input.GetAxisRaw("X axis")< -0.4f) && isMovingRight) {
		 StartCoroutine("Right");
		isMovingRight = false;
		
			
	}		
//			
	if ((Input.GetAxisRaw("Y axis")< 0.9f) && isSpeeding) {
		 StartCoroutine("Slow");
		isSpeeding = false;
			}
			
	if ((Input.GetAxisRaw("X axis")< 0.9f) && (Input.GetAxisRaw("X axis")> 0.4f) && isMovingLeft) {
		StartCoroutine("Left");
		isMovingLeft = false;
		}
//
//	


//if(!isMoving) {

//	Mount = GameObject.FindGameObjectWithTag("Player");
//	StartPosition = Mount.transform.rotation;
//	EndPosition.eulerAngles = 	new Vector3(0, 0, 0);
//	transform.rotation = Quaternion.Lerp(StartPosition, EndPosition, rollSpeed);	
			//animation.Play ("fly");
	
	}
	public IEnumerator Slow(){
//	 animation.CrossFade("LeftToCenter", 0.5f);
//		animation.Blend("fly", 1f, 0f);
		 animation.CrossFade("fly", 0.5f);
		yield return new WaitForSeconds(FadeSpeed);
	
	}
	
	
	public IEnumerator Left(){
//	 animation.CrossFade("LeftToCenter", 0.5f);
//		animation.Blend("fly", 1f, 0f);
		animation.Blend("LeftToCenter", 1f, 0f);
		yield return new WaitForSeconds(FadeSpeed);
	
	}
	
	public IEnumerator Right(){
//	animation.CrossFade("RightToCenter", 0.5f);
//		animation.Blend("fly", 1f, 0f);
		animation.Blend ("RightToCenter", 1f, 0f);
		yield return new WaitForSeconds(FadeSpeed);
		
	}
	
	void OnGUI()
	{
		
		GUI.TextArea(new Rect(400, 200, 250, 50), "Current Axis : " + currentAxis);
		GUI.TextArea(new Rect(400, 300, 250, 50), "Axis Value : " +  axisInput);
	}
	
	
	
	}
