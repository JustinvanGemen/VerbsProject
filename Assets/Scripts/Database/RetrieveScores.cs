using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Database
{
	public class RetrieveScores : MonoBehaviour {
		private string[] _highScores;
		private WWW _dataInformation;
		private string _textData;

		[SerializeField]
		private Text _text;
       
		public void HighscoreDisplayStart()
		{
			StartCoroutine (HighscoreDisplay ());
		}

		private IEnumerator HighscoreDisplay()
		{
			_dataInformation = new WWW("http://jvdwijk.com/Games/Verbs/");
			yield return _dataInformation;
			_textData = _dataInformation.text;

			_highScores = _textData.Split(";"[0]);
			_text.text = "1: " + _highScores[0] + "\n\n2: " + _highScores[1] + "\n\n3: " + _highScores[2] + "\n\n4: " + _highScores[3] + "\n\n5: " + _highScores[4];
		}

		public void SearchScoreStart(InputField givenName){
			StartCoroutine (SearchScore (givenName.text));
		}

		private IEnumerator SearchScore(string givenName)
		{
			_dataInformation = new WWW("http://jvdwijk.com/Games/Verbs/search.php?" + "Name=" + givenName);
			yield return _dataInformation;
			_textData = _dataInformation.text;
			_highScores = _textData.Split(";"[0]);
			print(_textData);
			_text.text = "1 : " + _highScores[0] + "\n\n" + "2: " + _highScores[1] + "\n\n" + "3: " + _highScores[2] + "\n\n" + "4: " + _highScores[3] + "\n\n" + "5: " + _highScores[4];
		}
	}
}
