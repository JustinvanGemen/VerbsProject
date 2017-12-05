using System.Collections;
using Database;
using UnityEngine;

namespace Player
{
	public class PlayerEat : MonoBehaviour {

		[SerializeField] private PlayerInputController _playerInput;
		private GameObject _tempFood;
		[SerializeField] private AddAndRemoveScores _addRemoveScore;
		private string _food;
		[SerializeField] private AudioSource _eat;

		private void OnTriggerStay (Collider other)
		{
			if (!_playerInput.GetEatInput || !other.CompareTag("Food")) return;
			switch (other.name)
			{
				case "Cake":
					_addRemoveScore.Score = 10;
					break;
				case "Banana":
					_addRemoveScore.Score = -15;
					break;
				case"DragonFruit":
					_addRemoveScore.Score = -5;
					break;
				case"Waffle":
					_addRemoveScore.Score = 5;
					break;
				case"IceCream":
					_addRemoveScore.Score = 15;
					break;
				case"Hamburger":
					_addRemoveScore.Score = 20;
					break;
			}
			other.name = "Eaten";
			_tempFood = other.gameObject;
			StartCoroutine ("Eat");
		}
		private IEnumerator Eat()
		{
			_eat.Play ();
			_playerInput.SwitchMovement = false;
			yield return new WaitForSeconds (1f);
			Destroy (_tempFood);
			_playerInput.SwitchMovement = true;
		}
	}
}
