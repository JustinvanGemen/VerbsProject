using UnityEngine;

namespace Player
{
	public class PlayerMovement : MonoBehaviour {

		[SerializeField] private float _speed = 5;
		[SerializeField] private AudioSource _run;
		[SerializeField] private PlayerInputController _playerInput;
		private Rigidbody _rigidBody;
		
		private void Start ()
		{
			_rigidBody = GetComponent<Rigidbody> ();
		}

		private void FixedUpdate ()
		{
			_rigidBody.velocity = _playerInput.GetMovementInput * _speed;
			if(_playerInput.GetMovementInput !=  new Vector3(0,0,0) && _run.isPlaying == false)
			{
				_run.Play ();
			}
		}
	}
}