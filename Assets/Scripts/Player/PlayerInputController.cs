using UnityEngine;
using System.Collections;

public class PlayerInputController : MonoBehaviour {

	private Vector3 movement;
	private bool eat = false;
	private float moveHorizontal;
	private float moveVertical;
	private bool canMove = true;

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
		{
			eat = true;
		}
		else
		{
			eat = false;
		}
	}

	public Vector3 GetMovementInput
	{
		get{return movement;}
	}

	public bool GetEatInput
	{
		get{return eat;}
	}
	public bool SwitchMovement
	{
		set
		{ canMove = value; }
	}
}