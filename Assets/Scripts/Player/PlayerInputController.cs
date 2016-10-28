using UnityEngine;
using System.Collections;

public class PlayerInputController : MonoBehaviour {

	private Vector3 movement;
	private bool eat = false;
	private float moveHorizontal;
	private float moveVertical;

	void FixedUpdate()
	{
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");

		movement = new Vector3 (moveHorizontal, 0, moveVertical);

		if(Input.GetAxis("Eat")== 1)
		{
			eat = true;
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
}
