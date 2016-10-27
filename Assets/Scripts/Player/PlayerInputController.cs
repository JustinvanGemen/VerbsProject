using UnityEngine;
using System.Collections;

public class PlayerInputController : MonoBehaviour {

	private Vector3 movement;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		movement = new Vector3 (moveHorizontal, 0, moveVertical);
	}

	public Vector3 GetInput
	{
		get{return movement;}
	}
}
