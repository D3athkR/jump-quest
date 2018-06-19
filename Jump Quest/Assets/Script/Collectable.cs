using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	private LevelManager GameLevelManager;
	public int Coinvalue;


	// Use this for initialization
	void Start () {
		GameLevelManager=FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D other){

		if (other.tag=="Player"){
			GameLevelManager.AddCoins(Coinvalue);
			Destroy(gameObject);
		}
	}

}
