using UnityEngine;

namespace Player
{
	public class PlayerInputController : MonoBehaviour {
		private float _moveHorizontal;
		private float _moveVertical;
		private bool _canMove = true;

		public PlayerInputController()
		{
			GetPauseInput = false;
			GetEatInput = false;
		}

		private void FixedUpdate()
		{
			_canMove = true;
			_moveHorizontal = Input.GetAxis ("Horizontal");
			_moveVertical = Input.GetAxis ("Vertical");

			GetMovementInput = _canMove == true ? new Vector3 (_moveHorizontal, 0, _moveVertical) : new Vector3 (0, 0, 0);
			GetEatInput = Input.GetButtonDown("Eat");
		}

		private void Update()
		{
			GetPauseInput = Input.GetButtonDown("Pause");
		}

		public Vector3 GetMovementInput { get; private set; }

		public bool GetEatInput { get; private set; }

		public bool GetPauseInput { get; private set; }

		public bool SwitchMovement
		{
			set { _canMove = value; }
		}
	}
}