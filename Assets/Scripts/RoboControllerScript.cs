﻿using UnityEngine;
using System.Collections;

public class RoboControllerScript : MonoBehaviour {

	public float maxSpeed = 10f;

	bool facingRight = true;

	Animator anim;

	bool grounded = false;

	public Transform groundCheck;

	float groundRadius = 0.2f;

	public LayerMask whatIsGround;

	public float jumpForce = 500f;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle(groundCheck.position,groundRadius,whatIsGround);
		anim.SetBool ("Ground",grounded);
		anim.SetFloat ("vSpeed",rigidbody2D.velocity.y);



		float move = Input.GetAxis("Horizontal");

		anim.SetFloat ("Speed",Mathf.Abs(move));

		rigidbody2D.velocity = new Vector2 (move*maxSpeed , rigidbody2D.velocity.y);

		if (move > 0 && !facingRight) {
			flip();
		
		}else if(move < 0 && facingRight){

			flip();
		} 
	
	}

	void Update(){

		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
				
			anim.SetBool("Ground",false);
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
	
	
	
	}

	//flip when directions are changed
	void flip(){

		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;

		theScale.x *= -1;

		transform.localScale = theScale;
	}
}
