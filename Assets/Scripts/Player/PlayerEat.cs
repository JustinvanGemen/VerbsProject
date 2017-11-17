﻿using UnityEngine;
using System.Collections;
using Database;

public class PlayerEat : MonoBehaviour {

	[SerializeField]
	private PlayerInputController playerInput;
	private GameObject tempFood;
	[SerializeField]
	private AddAndRemoveScores addRemoveScore;
	private string Food;
	[SerializeField]
	private AudioSource eat;

	void OnTriggerStay (Collider other)
	{
		if(playerInput.GetEatInput && other.CompareTag("Food"))
		{
			switch (other.name)
			{
			case "Cake":
				addRemoveScore.Score = 10;
				break;
			case "Banana":
				addRemoveScore.Score = -15;
				break;
			case"DragonFruit":
				addRemoveScore.Score = -5;
				break;
			case"Waffle":
				addRemoveScore.Score = 5;
				break;
			case"IceCream":
				addRemoveScore.Score = 15;
				break;
			case"Hamburger":
				addRemoveScore.Score = 20;
				break;
			}
			other.name = "Eaten";
			tempFood = other.gameObject;
			StartCoroutine ("Eat");
		}
	}
	private IEnumerator Eat()
	{
		eat.Play ();
		playerInput.SwitchMovement = false;
		yield return new WaitForSeconds (1f);
		Destroy (tempFood);
		playerInput.SwitchMovement = true;
	}
}
