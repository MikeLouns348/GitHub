using UnityEngine;
using System.Collections;

public class ProjectileBehaviour : MonoBehaviour {

	public int moveSpeed = 10;

	void Update () {
		transform.Translate(Vector3.forward * moveSpeed);
	}
}
