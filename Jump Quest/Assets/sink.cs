using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sink : MonoBehaviour {
private LevelManager levelmanager; 


	void OnCollisionEnter2D(Collision2D collision) 
{
		levelmanager = GameObject.FindObjectOfType<LevelManager> (); 
		levelmanager.LoadLevel ("sink");
		print ("Collision");
		GameObject.Find ("Player1").SendMessage ("Finish"); 
}
}
