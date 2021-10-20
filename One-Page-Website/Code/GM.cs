using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {
public int life = 3;
public int score = 0;
	


	
	/// <summary>
	/// Game master keeps track of invaders and player
	/// If player dies, respawn the player 
	/// If all invaders died, print "win"
	/// </summary>
	
	void Start () {
	
	}
	
	void Update () {
	
	}
	
	public void loselife() {
		life --;
		if (life <=0)
		Application.LoadLevel (1);
		
		
		
		
	}
	
}
