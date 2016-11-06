using UnityEngine;
using System.Collections;

public class PlayerEat : MonoBehaviour {

	[SerializeField]
	private PlayerInputController playerInput;
	
	// Update is called once per frame
	void OnTriggerStay (Collider other)
	{
		if (playerInput.GetEatInput && other.CompareTag("Food"))
		{
			StartCoroutine ("Eat");
			Destroy (other.gameObject);
		}
	}
	IEnumerator Eat()
	{
		playerInput.SwitchMovement = false;
		yield return new WaitForSeconds (1f);
		playerInput.SwitchMovement = true;
	}
}
