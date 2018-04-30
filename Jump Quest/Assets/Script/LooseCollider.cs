using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {
private LevelManager levelManager; 
	
	
	void Start(){
	
	
	
	
	}
	
	
	void OnCollisionEnter2D(Collision2D collision){
		levelManager = GameObject.FindObjectOfType<LevelManager> (); 
	levelManager.LoadLevel ("Lose");
		print ("Collision");
	}
		
						
	}
	
	

