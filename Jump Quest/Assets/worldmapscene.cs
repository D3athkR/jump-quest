using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldmapscene : MonoBehaviour {
LevelManager levelmanager;

	void OnCollisionEnter2D(Collision2D collision) 
{
		levelmanager = GameObject.FindObjectOfType<LevelManager> (); 
		levelmanager.LoadLevel ("point system");
		print ("Collision");
		GameObject.Find ("Player1").SendMessage ("Finish"); 
}
}
