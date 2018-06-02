using UnityEngine;
using System.Collections;

public class botcollider : MonoBehaviour {
public GameObject item;
private ScoreKeeper scorekeeper;
public int scoreValue = 150;


	void Start(){
		scorekeeper = FindObjectOfType<ScoreKeeper>(); 
		}

	void OnCollisionEnter2D(Collision2D other){
	item box= GetComponent<Collider2D>().gameObject.GetComponent<item>();
	if(item)
	scorekeeper.score(scoreValue);
		print("object collide");
		
		

	}
	
	
	}


