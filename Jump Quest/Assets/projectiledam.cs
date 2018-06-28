using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectiledam : MonoBehaviour {

 void OnCollisionEnter2D(Collider2D col)
 {
 Destroy(gameObject);
 }
	
	// Update is called once per frame
	void Update () {
		
	}
}
