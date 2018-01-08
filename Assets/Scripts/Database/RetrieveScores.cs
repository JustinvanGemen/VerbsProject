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
			_dataInformation = new WWW("http://jvdwijk.com/Games/ESR/");
			yield return _dataInformation;
			_textData = _dataInformation.text;

			_highScores = _textData.Split(";"[0]);

			var i = 1;
			_text.text = "1: ";
			foreach (var score in _highScores)
			{
				if (score == null || score == _highScores[5]) yield break;
				_text.text += score + "\n\n" + i + " ";
				i++;
			}	
		}

		public void SearchScoreStart(InputField givenName){
			StartCoroutine (SearchScore (givenName.text));
		}

		private IEnumerator SearchScore(string givenName)
		{
			_text.text = "";
			_dataInformation = new WWW("http://jvdwijk.com/Games/ESR/search.php?" + "Name=" + givenName);
			yield return _dataInformation;
			_textData = _dataInformation.text;
			_highScores = _textData.Split(";"[0]);
			print(_textData);
		
			var loopCount = Mathf.Min(_highScores.Length, 5);
			for (var i = 0; i < loopCount; i++)
			{
				var score = _highScores[i];
				if (score == "" ) yield break;
				_text.text += (i + 1) + " " + score + "\n\n";
			}
		}
	}
}
