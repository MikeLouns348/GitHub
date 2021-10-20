using UnityEngine;
using System.Collections;

public class NPCBehaviour : MonoBehaviour {

	public Transform target;
	public int attackRange = 1;
	public int attackSpeed = 1;
	private bool attacking = false;

	protected void Update() {
		if (target != null && !attacking) {
			StartCoroutine(Engage());
		}
	}
	
	protected virtual IEnumerator Engage() {
		attacking = true;
		while (target != null) {
			transform.forward = target.transform.position - transform.position;
			yield return StartCoroutine(Attack());
		}
		attacking = false;
	}
	
	protected virtual IEnumerator Attack() { 
		yield return new WaitForSeconds(5 / attackSpeed); 
	}
}
