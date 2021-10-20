using UnityEngine;
using System.Collections;

public class Text2 : MonoBehaviour {

	// GUITEXT DEMO
	public int i = 0;
	public GUIText score;
	
	 void Start () {
	 score.text = "Score: " + i.ToString();
	 score.pixelOffset = new Vector2(-Screen.width/2 * .90f,
	 Screen.height/2 * .90f);
	 }
	
	 public void addScore () {
	 i++;
	 score.text = "Score: " + i.ToString();
	 }
 }	
