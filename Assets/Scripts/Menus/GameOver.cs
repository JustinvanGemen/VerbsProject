using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	[SerializeField]
	private CanvasSwitcher changeMenu;
	[SerializeField]
	private GameObject canvas;
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
				tempScore /= 3;
				removeScore.Score = -tempScore;
			}
			changeMenu.ScreenUpdate(canvas);
			Time.timeScale = 0;
		}
	}
}
