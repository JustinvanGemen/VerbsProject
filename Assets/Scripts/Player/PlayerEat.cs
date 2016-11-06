using UnityEngine;
using System.Collections;

public class PlayerEat : MonoBehaviour {

	[SerializeField]
	private PlayerInputController playerInput;
	private GameObject tempFood;
	
	// Update is called once per frame
	void OnTriggerStay (Collider other)
	{
		if (playerInput.GetEatInput && other.CompareTag("Food"))
		{
			tempFood = other.gameObject;
			StartCoroutine ("Eat");
		}
	}
	IEnumerator Eat()
	{
		playerInput.SwitchMovement = false;
		yield return new WaitForSeconds (1f);
		Destroy (tempFood);
		playerInput.SwitchMovement = true;
	}
}
