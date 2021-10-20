using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// GUITEXT DEMO
	public int i = 0;
	public GUIText score;
	public int kill = 100;
	
	 void Start () {
	 score.text = "Score: " + i.ToString();
	 score.pixelOffset = new Vector2(-Screen.width/2 * .90f,
	 Screen.height/2 * .90f);
	 }
	
	 public void addScore () {
	 i+= kill;
	 score.text = "Score: " +i.ToString ();
	 }
 }	
