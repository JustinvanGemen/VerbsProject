using UnityEngine;

namespace GeneralItems
{
	public class ObjectMovement : MonoBehaviour {

		private Rigidbody _rigidBody;
		[SerializeField]
		private int _speed;

		private void Start()
		{
			_rigidBody = GetComponent<Rigidbody> ();
		}

		private void FixedUpdate ()
		{
			_rigidBody.MovePosition (transform.position + transform.forward * _speed/100);
		}

		private void OnTriggerEnter(Collider other)
		{
			if(other.CompareTag("WayPoint"))
			{
				transform.Rotate (new Vector3 (0, 90, 0));
			}
		}
	}
}
