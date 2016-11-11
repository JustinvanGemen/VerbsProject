﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RetrieveScores : MonoBehaviour {
    private string[] highScores;
	private WWW dataInformation;
	private string textData;

	[SerializeField]
	private Text text;
       
	public void HighscoreDisplayStart()
	{
		StartCoroutine (HighscoreDisplay ());
	}

	IEnumerator HighscoreDisplay()
	{
		dataInformation = new WWW("http://jvdwijk.com/Games/Verbs/");
		yield return dataInformation;
		textData = dataInformation.text;

		highScores = textData.Split(";"[0]);
		text.text = "1: " + highScores[0] + "\n2: " + highScores[1] + "\n3: " + highScores[2] + "\n4: " + highScores[3] + "\n5: " + highScores[4];
	}

	public void SearchScoreStart(InputField givenName){
		StartCoroutine (SearchScore (givenName.text));
	}

	IEnumerator SearchScore(string givenName)
	{
		dataInformation = new WWW("http://jvdwijk.com/Games/Verbs/search.php?" + "Name=" + givenName);
		yield return dataInformation;
		textData = dataInformation.text;
		highScores = textData.Split(";"[0]);
		text.text = "1 : " + highScores[0] + "\n\n2: " + highScores[1] + "\n\n3: " + highScores[2] + "\n\n4: " + highScores[3] + "\n\n5: " + highScores[4];

	}
}
