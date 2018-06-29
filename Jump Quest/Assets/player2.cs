using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {
private Rigidbody2D myRB;
[SerializeField]
private float moveSpeed;
private bool facingRight;
private Animator anim;

[SerializeField]
private Transform[] groundPoints;
[SerializeField]
private float groundRadius;

[SerializeField]
private LayerMask WhatisGround;
private bool isGrounded;
private bool jump; 

[SerializeField]
private float jumpForce; 




	// Use this for initialization
	void Start () {
		facingRight=true;
		myRB=GetComponent<Rigidbody2D>();
		anim=GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float horizontal = Input.GetAxis ("Horizontal");
		isGrounded=IsGrounded();
		Debug.Log(horizontal);
		HandleMovement(horizontal);
		Flip(horizontal);
	}


	private void HandleMovement(float horiztonal)
	{
		myRB.velocity = new Vector2(horiztonal * moveSpeed,myRB.velocity.y);

		if(isGrounded && jump)
		{

		isGrounded=false; 
		myRB.AddForce(new Vector2(0,jumpForce));



		}


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

	private void HandleInput()
	{



	if(Input.GetKeyDown(KeyCode.Space))
	{
	jump=true;
	Debug.Log("jump ");
	}
	}






	private bool IsGrounded()
	{

	if(myRB.velocity.y <=0)
	{
		foreach(Transform point in groundPoints)
		{
			Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, WhatisGround);

			for (int i=0; i < colliders.Length; i++)
			{	
				if(colliders[i].gameObject != gameObject)
				{
					return true;

					}
					}



		}
		}


		return false;

	}

}
