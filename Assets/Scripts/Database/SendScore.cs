using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Database
{
	public class SendScore : MonoBehaviour {
    	
		private AddAndRemoveScores _addAndRemoveScores;
		private int _score;
		private string _scoreUrl;
		private WWW _webRequest;

		public void EnterScore(InputField winnerName)
		{
			_addAndRemoveScores = GetComponent<AddAndRemoveScores>();
			_score = _addAndRemoveScores.Score;
			StartCoroutine(EnterEndScore(_score, winnerName.text));
		}

		private IEnumerator EnterEndScore (int score, string playerID) {
			_scoreUrl = "http://jvdwijk.com/Games/Verbs/database.php" + "?Name=" + playerID + "&Score=" + score;
			_webRequest = new WWW(_scoreUrl);
			yield return _webRequest;
		}
	}
}
