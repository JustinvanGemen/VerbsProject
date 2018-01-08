using System.Collections;
using Database;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

namespace Player
{
	public class PlayerEat : MonoBehaviour {

		[SerializeField] private ThirdPersonUserControl _playerInput;
		private GameObject _tempFood;
		[SerializeField] private AddAndRemoveScores _addRemoveScore;
		private string _food;
		[SerializeField] private AudioSource _eat;
		
		private Material _material;
		[SerializeField] private float _calories;

		private void Start()
		{
			print(gameObject);
			_material = gameObject.GetComponentInChildren<Renderer>().material;
		}

		private void OnTriggerStay (Collider other)
		{
			if (!Input.GetButtonDown("Eat") || !other.CompareTag("Food")) return;
			switch (other.name)
			{
				case "Cake":
					_addRemoveScore.Score = 10;
					break;
				case "Banana":
					_addRemoveScore.Score = -15;
					break;
				case "DragonFruit":
					_addRemoveScore.Score = -5;
					break;
				case "Waffle":
					_addRemoveScore.Score = 5;
					break;
				case "Ice Cream":
					_addRemoveScore.Score = 15;
					break;
				case "Hamburger":
					_addRemoveScore.Score = 20;
					break;
			}
			other.name = "Eaten";
			_tempFood = other.gameObject;
			StartCoroutine ("Eat", _tempFood);	//start function Eat
		}
		private IEnumerator Eat(Object food)
		{
			_eat.Play();		//play Sound
			_playerInput.SwitchMovement = false;	//disable walking
			var size = _material.GetFloat("_Amount") + _calories;
			_material.SetFloat("_Amount", size);	//Set new size
			yield return new WaitForSeconds (0.35f);
			Destroy (food);
			_playerInput.SwitchMovement = true;	//enable walking
		}
	}
}