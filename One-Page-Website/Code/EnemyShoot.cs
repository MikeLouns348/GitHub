using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
public GameObject EnemyBullet;
	
void Start(){
		StartCoroutine("Shoot"); 
	
		}
		
		
	IEnumerator Shoot(){
	yield return new WaitForSeconds(3);
		Instantiate(EnemyBullet, transform.position, transform.rotation);
		StartCoroutine("Shoot");
			
      
	}
  }
