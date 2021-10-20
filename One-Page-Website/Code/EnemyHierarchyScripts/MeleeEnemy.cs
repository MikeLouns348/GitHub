using UnityEngine;
using System.Collections;

public class MeleeEnemy : NPCBehaviour {
	
	protected override IEnumerator Attack() {
		print("i'm gonna get ya");
		yield return StartCoroutine(base.Attack());
	}
}
