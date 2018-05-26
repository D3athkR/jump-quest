using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

	public float speed=2; 
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D Other)
	{
		if (Other.tag=="Player"&&Input.GetKey(KeyCode.UpArrow)){
			Other.GetComponent<Rigidbody2D>().velocity=new Vector2(0,speed);
			}
		else if (Other.tag=="Player"&&Input.GetKey(KeyCode.DownArrow)){
			Other.GetComponent<Rigidbody2D>().velocity=new Vector2(0,-speed);
			}
		else{
			Other.GetComponent<Rigidbody2D>().velocity=new Vector2(0,0.6f);
			}
	}
}
