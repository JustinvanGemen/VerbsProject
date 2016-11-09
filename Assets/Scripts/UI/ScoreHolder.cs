using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour {

	[SerializeField]
	private Text text;

	[SerializeField]
	private AddAndRemoveScores score;

	void Update () {
		text.text = score.Score.ToString();
	}
}
