﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deffaultitem2 : MonoBehaviour {

void OnCollisionEnter2D(Collision2D collision){

	var hit = collision.gameObject;
	var health = hit.GetComponent<health>(); 
	if (health != null)
	{
	health.TakeDamage(50);

		
	}
}
}