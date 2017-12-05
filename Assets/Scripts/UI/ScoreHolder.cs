using Database;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class ScoreHolder : MonoBehaviour {

		[SerializeField] private Text _text;

		[SerializeField] private AddAndRemoveScores _score;

		private void Update () {
			_text.text = _score.Score.ToString();
		}
	}
}
