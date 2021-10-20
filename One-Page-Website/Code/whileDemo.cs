using UnityEngine;
using System.Collections;

public class whileDemo : MonoBehaviour {

	void Start () {
		// Run the coroutine once in Start because the coroutine loops
		StartCoroutine(Move());
	}
	
	IEnumerator Move() {
		// Start move left
		StartCoroutine(MoveLeft());
		// Wait 2 seconds
		yield return new WaitForSeconds(2);
		// Repeat
		StartCoroutine(Move());
	}
	
	IEnumerator MoveLeft() {
		float t = 0;
		Vector3 startPos = transform.position;
		Vector3 endPos = transform.position;
		endPos.x -= 3;
		// as long as test case is true
		while (t < 1) {
			t += Time.deltaTime;
			// Lerp moves smoothly from startPos to endPos
			// t ranges from 0 to 1
			transform.position = Vector3.Lerp(startPos, endPos, t);
			yield return 0;
		}
	}
}
