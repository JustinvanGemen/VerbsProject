using Database;
using UnityEngine;

namespace Menus
{
	public class GameOver : MonoBehaviour {

		[SerializeField]
		private CanvasSwitcher _changeMenu;
		[SerializeField]
		private GameObject _canvas;
		private int _tempScore;
		[SerializeField]
		private AddAndRemoveScores _removeScore;

		private void OnTriggerEnter (Collider other)
		{
			if (!other.CompareTag("Player")) return;
			if(gameObject.CompareTag("Enemy"))
			{
				_tempScore = _removeScore.Score;
				_tempScore /= 3;
				_removeScore.Score = -_tempScore;
			}
			_changeMenu.ScreenUpdate(_canvas);
			Time.timeScale = 0;
		}
	}
}
