using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float speed = 5;
	private Rigidbody rigidBody;

	[SerializeField]
	private PlayerInputController playerInput;

	// Use this for initialization
	void Start ()
	{
		rigidBody = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void FixedUpdate ()
	{
		rigidBody.velocity = playerInput.GetInput * speed;
	}
}