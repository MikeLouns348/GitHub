using UnityEngine;
using System.Collections;

public class BirdAnims : MonoBehaviour {
	
	public Quaternion StartPosition;
	public Quaternion EndPosition;
	public Quaternion LeftPosition;
	public Quaternion RightPosition;
	public float rollSpeed = .1f;
	public bool isMovingLeft;
	public bool isMovingRight;
	public bool isSpeeding;
	public bool isMoving;
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
		StartPosition = transform.rotation;
		
		
		//debuging purposes...gives gui access to axis and value
		if(Input.GetAxisRaw("5th axis")> 0.3|| Input.GetAxisRaw("5th axis") < -0.3){
			currentAxis = "5th axis";
			axisInput = Input.GetAxisRaw("5th axis");
			
			}
		
		
		if(Input.GetAxisRaw("Y axis")> 0.3|| Input.GetAxisRaw("Y axis") < -0.3){
			currentAxis = "Y axis";
			axisInput = Input.GetAxisRaw("Y axis");
		}
		
				if(Input.GetAxisRaw("X axis")> 0|| Input.GetAxisRaw("X axis") < 0){
			currentAxis = "X axis";
			axisInput = Input.GetAxisRaw("X axis");
		}
	
	}
	
	
//	public IEnumerator Left(){
////	 animation.CrossFade("LeftToCenter", 0.5f);
////		animation.Blend("fly", 1f, 0f);
//		animation.Blend("LeftToCenter", 1f, 0f);
//		yield return new WaitForSeconds(0);
//	
//	}
//	
//	public IEnumerator Right(){
////	animation.CrossFade("RightToCenter", 0.5f);
////		animation.Blend("fly", 1f, 0f);
//		animation.Blend ("RightToCenter", 1f, 0f);
//		yield return new WaitForSeconds(0);
//		
	
	
	void OnGUI()
	{
		
		GUI.TextArea(new Rect(400, 200, 250, 50), "Current Axis : " + currentAxis);
		GUI.TextArea(new Rect(400, 300, 250, 50), "Axis Value : " +  axisInput);
	}
	
	
	
	}
