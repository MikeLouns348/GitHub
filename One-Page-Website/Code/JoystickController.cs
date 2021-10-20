using UnityEngine;
using System.Collections;

public class JoystickController : MonoBehaviour {
	


	void Start () {
	
	}
	
	void Update () 
	{
		getAxis();
		getButton();
		
	
	}
	

	void getAxis()
	{
		if(Input.GetAxisRaw("X axis")> 0.3|| Input.GetAxisRaw("X axis") < -0.3)
		{
			
		}
		
		if(Input.GetAxisRaw("Y axis")> 0.3|| Input.GetAxisRaw("Y axis") < -0.3)
		{
			
		}
		
		if(Input.GetAxisRaw("3rd axis")> 0.3|| Input.GetAxisRaw("3rd axis") < -0.3)
		{
			
		}
		
		if(Input.GetAxisRaw("4th axis")> 0.3|| Input.GetAxisRaw("4th axis") < -0.3)
		{
			
		}
		
		if(Input.GetAxisRaw("5th axis")> 0.3|| Input.GetAxisRaw("5th axis") < -0.3)
		{
			
		}
		
		if(Input.GetAxisRaw("6th axis")> 0.3|| Input.GetAxisRaw("6th axis") < -0.3)
		{
			
		}
		
		if(Input.GetAxisRaw("7th axis")> 0.3|| Input.GetAxisRaw("7th axis") < -0.3)
		{
			
		}
		
		if(Input.GetAxisRaw("8th axis") > 0.3|| Input.GetAxisRaw("8th axis") < -0.3)
		{
			
		}
	}
	
	/// <summary>
	/// get the button data of the joystick
	/// </summary>
	void getButton()
	{
		if(Input.GetButton("joystick button 0")){
		}
		   
		if(Input.GetButton("joystick button 1")){
		}	
		   
		if(Input.GetButton("joystick button 2")){
		}
		   
		if(Input.GetButton("joystick button 3")){
		}
		   
		if(Input.GetButton("joystick button 4")){
		}
		   
		if(Input.GetButton("joystick button 5")){
			}
		   
		if(Input.GetButton("joystick button 6")){
		}
		   
		if(Input.GetButton("joystick button 7")){
		}
		   
		if(Input.GetButton("joystick button 8")){
		}
		   
		if(Input.GetButton("joystick button 9")){
		}
		   
		if(Input.GetButton("joystick button 10")){
		}
		   
		if(Input.GetButton("joystick button 11")){
		}
		   
		if(Input.GetButton("joystick button 12")){
		}
		   
		if(Input.GetButton("joystick button 13")){
		}
		   
		if(Input.GetButton("joystick button 14")){
		}
		
		if(Input.GetButton("joystick button 15")){
		}
		
		if(Input.GetButton("joystick button 16")){
		}
		
		if(Input.GetButton("joystick button 17")){
		}
		
		if(Input.GetButton("joystick button 18")){
		}
																					
		if(Input.GetButton("joystick button 19")){
		}
	}
	
	
	
}
