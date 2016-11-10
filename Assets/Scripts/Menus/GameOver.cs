using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	[SerializeField]
	private CanvasSwitcher changeMenu;
	[SerializeField]
	private GameObject canvas;
	[SerializeField]
	private PlayerInputController playerInput;
	private int tempScore;
	[SerializeField]
	private AddAndRemoveScores removeScore;

	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Player"))
		{
			if(gameObject.CompareTag("Enemy"))
			{
				tempScore = removeScore.Score;
				tempScore /= 4;
				removeScore.Score = -tempScore;
			}
			changeMenu.ScreenUpdate(canvas);
			playerInput.enabled = false;
		}
	}
}
