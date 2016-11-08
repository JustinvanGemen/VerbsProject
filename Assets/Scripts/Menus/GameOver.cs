using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	[SerializeField]
	private CanvasSwitcher changeMenu;
	[SerializeField]
	private GameObject canvas;

	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Player"))
		{
			changeMenu.ScreenUpdate(canvas);
		}
	}
}
