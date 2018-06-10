using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder1 : MonoBehaviour {

	public float speed1=4; 
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D Other)
	{
		if (Other.tag=="Player"&&Input.GetKey(KeyCode.RightArrow)){
			Other.GetComponent<Rigidbody2D>().velocity=new Vector2(speed1,0);
			}
		else if (Other.tag=="Player"&&Input.GetKey(KeyCode.LeftArrow)){
			Other.GetComponent<Rigidbody2D>().velocity=new Vector2(-speed1,0);
			}
		else{
			Other.GetComponent<Rigidbody2D>().velocity=new Vector2(2f,0.6f);
			}
	}
}
