﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float speed = 5;
	private Rigidbody rigidBody;

	[SerializeField]
	private AudioSource run;

	[SerializeField]
	private PlayerInputController playerInput;

	void Start ()
	{
		rigidBody = GetComponent<Rigidbody> ();
	}
		
	void FixedUpdate ()
	{
		rigidBody.velocity = playerInput.GetMovementInput * speed;
		if(playerInput.GetMovementInput !=  new Vector3(0,0,0))
		{
			run.Play ();
		}
		else
		{
			run.Pause ();
		}
	}
}