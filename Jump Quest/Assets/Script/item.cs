using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {
	private ScoreKeeper scorekeeper;
	public int scoreValue = 150;
	
	
	void Start(){
		scorekeeper = FindObjectOfType<ScoreKeeper>(); 
	}
	
	void OnTriggerEnter2D(Collider2D other){
		item box= GetComponent<Collider2D>().gameObject.GetComponent<item>();
		if(box)
			scorekeeper.score(scoreValue);
		print("object collide");
		
		
		
	}
	
	
}