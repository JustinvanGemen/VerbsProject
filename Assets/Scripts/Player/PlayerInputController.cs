using UnityEngine;
using System.Collections;

public class PlayerInputController : MonoBehaviour {

	private Vector3 movement;
	private float moveHorizontal;
	private float moveVertical;
	private bool canMove = true;
	private bool eat = false;
	private bool pause = false;

	void FixedUpdate()
	{
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");

		if(canMove == true)
		{
			movement = new Vector3 (moveHorizontal, 0, moveVertical);
		}
		else
		{
			movement = new Vector3 (0, 0, 0);
		}

		if(Input.GetAxis("Eat") != 0)
		{ eat = true; }
		else
		{ eat = false; }
	}

	void Update()
	{
		if(Input.GetButtonDown("Pause"))
		{ pause = true; }
		else
		{ pause = false; }
	}

	public Vector3 GetMovementInput
	{
		get{return movement;}
	}

	public bool GetEatInput
	{
		get{return eat;}
	}

	public bool GetPauseInput
	{
		get{return pause;}
	}

	public bool SwitchMovement
	{
		set
		{ canMove = value; }
	}
}