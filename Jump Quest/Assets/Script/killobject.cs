
using UnityEngine;
using System.Collections;

public class killobject : MonoBehaviour {
public Transform spawnPoint;
private GameObject items;



void OnTriggerEnter2D(Collision2D col){
	if(col.transform.CompareTag("item"))
	col.transform.position=spawnPoint.position; 
		items = GameObject.FindGameObjectWithTag ("item");
	DestroyObject (items);
	Debug.Log ("Destroyed");

}

	void OnCollisionEnter2D(Collision2D col){

	items = GameObject.FindGameObjectWithTag ("item");
	DestroyObject (items);
	Debug.Log ("Destroyed");

}
}

