using UnityEngine;
using System.Collections;

public class PlayerEat : MonoBehaviour {

	[SerializeField]
	private PlayerInputController playerInput;
	private GameObject tempFood;
	[SerializeField]
	private AddAndRemoveScores addRemoveScore;
	
	// Update is called once per frame
	void OnTriggerStay (Collider other)
	{
		if (playerInput.GetEatInput && other.CompareTag("Food"))
		{
			if(other.name == "Cake")
			{
				other.name = "Eaten";
				addRemoveScore.Score = 10;
			}
			tempFood = other.gameObject;
			StartCoroutine ("Eat");
		}
	}
	private IEnumerator Eat()
	{
		playerInput.SwitchMovement = false;
		yield return new WaitForSeconds (1f);
		Destroy (tempFood);
		playerInput.SwitchMovement = true;
	}
}
