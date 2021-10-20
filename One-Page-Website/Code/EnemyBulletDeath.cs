using UnityEngine;
using System.Collections;

public class EnemyBulletDeath : MonoBehaviour {

	public GameObject GM;
	
	
	// Use this for initialization
	void Start () {
	GM = GameObject.Find("GM");
	}
	
	// Update is called once per frame
	void Update () {
	
		
		renderer.material.color = Color.yellow;



Destroy (gameObject, 1);
}
	
	
		void OnTriggerEnter(Collider other) {
		if (other.name == "wolf(Clone)")
			Destroy(gameObject);
			
	
		if (other.name == "Cow(Clone)")
			Destroy(gameObject);
		
}
}
		
//
//if (hit.collider.name == "Wolf2(Clone)") {
//	referee.GetComponent("Score").addScore(100);
//	Destroy (gameObject);
//	Destroy(hit.gameObject);
//	}
//}

	

