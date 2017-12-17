using Database;
using UnityEngine;

namespace Menus
{
	public class GameOver : MonoBehaviour
	{
		[SerializeField] private string _scriptHolder;
		[SerializeField] private int _gameOverCanvas;
		private CanvasSwitcher _changeMenu;
		private AddAndRemoveScores _removeScore;
	
		private int _tempScore;

		private void Start()
		{
			var tempObject = GameObject.Find(_scriptHolder);
			_changeMenu = tempObject.GetComponent<CanvasSwitcher>();
			_removeScore = tempObject.GetComponent<AddAndRemoveScores>();
			_gameOverCanvas = 2;
		}
		
		private void OnTriggerEnter (Collider other)
		{
			if (!other.CompareTag("Player")) return;
			if(gameObject.CompareTag("Enemy"))
			{
				_tempScore = _removeScore.Score;
				_tempScore /= 3;
				_removeScore.Score = -_tempScore;
			}
			_changeMenu.ScreenUpdate(_gameOverCanvas);
			Time.timeScale = 0;
		}
	}
}
