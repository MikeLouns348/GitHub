using UnityEngine;
using System.Collections;

public class RangedEnemy : NPCBehaviour {

	public Transform projectile;
	
	protected override IEnumerator Attack() {
		print("bang");
		yield return new WaitForSeconds(1 / attackSpeed); 
	}
}