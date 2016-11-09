using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	[SerializeField]
	private CanvasSwitcher changeMenu;
	[SerializeField]
	private GameObject canvas;
	[SerializeField]
	private PlayerMovement playerMovement;
	[SerializeField]
	private Pause pause;

	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Player"))
		{
			changeMenu.ScreenUpdate(canvas);
			playerMovement.enabled = false;
			pause.enabled = false;
		}
	}
}
