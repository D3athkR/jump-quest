using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randxspawn : MonoBehaviour {
public GameObject enemy; 
float randX;
Vector2 wheretoSpawn;
public float Spawnrate= 2f;
float nextSpawn= 0.0f;

	void Update () {

	if (Time.time > nextSpawn)
	{
	nextSpawn = Time.time +Spawnrate;
	randX = Random.Range(-16.55f,-1.94f);
	wheretoSpawn= new Vector2 (randX,transform.position.y);
	Instantiate (enemy, wheretoSpawn, Quaternion.identity);

				
	}
}
}
