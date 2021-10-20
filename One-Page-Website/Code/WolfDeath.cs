using UnityEngine;
using System.Collections;

public class WolfDeath : MonoBehaviour {
	public GameObject gameMaster;

	// Use this for initialization
	void Start () {
		
		gameMaster = GameObject.Find ("Referee");
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other) {
		if (other. name == "Bullet(Clone)")
        Destroy(gameObject);
						
	}
//	
	void OnDestroy(){
	
		gameMaster.GetComponent<Score>().addScore();
				
	
	
	}
}