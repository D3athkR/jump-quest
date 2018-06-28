using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {
private Rigidbody2D myRB;
[SerializeField]
private float moveSpeed;
private bool facingRight;
private Animator anim;

	// Use this for initialization
	void Start () {
		facingRight=true;
		myRB=GetComponent<Rigidbody2D>();
		anim=GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float horizontal = Input.GetAxis ("Horizontal");
		Debug.Log(horizontal);
		HandleMovement(horizontal);
		Flip(horizontal);
	}


	private void HandleMovement(float horiztonal)
	{
		myRB.velocity = new Vector2(horiztonal * moveSpeed,myRB.velocity.y);

		anim.SetFloat("speed", Mathf.Abs(horiztonal));

	}


	private void Flip(float horizontal)
	{

	if(horizontal>0 && !facingRight || horizontal<0 &&facingRight)
	{
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;

		theScale.x*= -1;

		transform.localScale = theScale; 



	}

}
}
