using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {
private LevelManager levelmanager; 



	void OnCollisionEnter2D(Collision2D collision) 
{
		levelmanager = GameObject.FindObjectOfType<LevelManager> (); 
		levelmanager.LoadLevel ("scoreboard");
		print ("Collision");
		GameObject.Find ("Player1").SendMessage ("Finish"); 
		

		
		
	
	}
}
