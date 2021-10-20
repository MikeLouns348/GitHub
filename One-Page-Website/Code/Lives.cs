using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	// GUITEXT DEMO
	public int i = 3;
	public GUIText score;
	
	 void Start () {
	 score.text = "Lives: " + i.ToString();
	 score.pixelOffset = new Vector2(Screen.width/2 * .70f,
	 Screen.height/2 * .90f);
	 }
	
	 public void loselife () {
	 i--;
	 score.text = "Lives: " + i.ToString();
		
	if(i <=0)
		Application.LoadLevel (1);

	}
 }	
