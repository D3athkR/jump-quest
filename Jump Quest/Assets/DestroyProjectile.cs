using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour {
public float delay;
GameObject projectile;
	
	// Update is called once per frame
	void Start () {
		Destroy (gameObject, delay); 
		Debug.Log ("destroyed projectile");

	}


	void OnCollisionEnter2D(Collision2D col)
	{
	if(col.transform.CompareTag("Player"));
	projectile = GameObject.FindGameObjectWithTag ("PLayer");
	Destroy(gameObject);
	}
}
