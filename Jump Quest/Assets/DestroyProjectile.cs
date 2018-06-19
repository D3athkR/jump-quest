using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour {
public float delay;
	
	// Update is called once per frame
	void Start () {
		Destroy (gameObject, delay); 
		Debug.Log ("destroyed projectile");

	}
}
