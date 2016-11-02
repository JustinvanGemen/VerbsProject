using UnityEngine;
using System.Collections;

public class PlayerEat : MonoBehaviour {

	[SerializeField]
	private PlayerInputController playerInput;

	private PlayerMovement playerMovement;

	// Use this for initialization
	void Start ()
	{
		playerMovement = GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (playerInput.GetEatInput)
		{
			StartCoroutine ("Eat");
		}
	}
	IEnumerator Eat()
	{
		playerMovement.enabled = false;
		yield return new WaitForSeconds (4f);
		playerMovement.enabled = true;
	}
}
