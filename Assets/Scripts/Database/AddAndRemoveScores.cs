using UnityEngine;

namespace Database
{
	public class AddAndRemoveScores : MonoBehaviour {
		private int _score;
		public int Score { get { return _score; } set { _score = _score + value;} }

		private void Start () {
			_score = 0;
		}
	}
}