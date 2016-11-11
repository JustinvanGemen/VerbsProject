using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour {

	private Rigidbody rigidBody;
	[SerializeField]
	private int speed;

	void Start()
	{
		rigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		rigidBody.MovePosition (transform.position + transform.forward * speed/100);
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("WayPoint"))
		{
			transform.Rotate (new Vector3 (0, 90, 0));
		}
	}
}
