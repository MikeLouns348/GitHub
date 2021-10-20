using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	
	public Quaternion StartPosition;
	public Quaternion EndPosition;
	public float rollSpeed = .1f;
	public bool isMovingLeft;
	public bool isMovingRight;
	public bool isMoving;
	public bool isSpeeding;
	public float FadeSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartPosition = transform.rotation;
	
	if ((Input.GetAxisRaw("5th axis")> 0.99f) && !isSpeeding){
		animation.Play("flap");
		isSpeeding = true;
		}
		
	if ((Input.GetAxisRaw("5th axis")< 0.9f) && isSpeeding) {
		StartCoroutine("Slow");
		isSpeeding = false;
		}
	
	if ((Input.GetAxisRaw("X axis")< -0.1f)){
		EndPosition.eulerAngles = 	new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -27);
		transform.rotation = Quaternion.Lerp(StartPosition, EndPosition, rollSpeed);
			isMoving = true;
		}
		
	if ((Input.GetAxisRaw("X axis")> 0.1f)){
		EndPosition.eulerAngles = 	new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 27);
		transform.rotation = Quaternion.Lerp(StartPosition, EndPosition, rollSpeed);
		isMoving = true;
		}
		
	if ((Input.GetAxisRaw("X axis")> -0.1f) && (Input.GetAxisRaw("X axis")< 0.1f) ){
	
		EndPosition.eulerAngles = 	new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);

		transform.rotation = Quaternion.Lerp(StartPosition, EndPosition, rollSpeed);	
		}

		

	
}

	public IEnumerator Slow(){
		animation.CrossFade("fly", 0.5f);
		yield return new WaitForSeconds(FadeSpeed);
		}
	

	}

