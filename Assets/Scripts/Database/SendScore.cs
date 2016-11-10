using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SendScore : MonoBehaviour {
    	
	private AddAndRemoveScores addAndRemoveScores;
	private int score;
	private string score_url;
	private WWW webRequest;

	public void EnterScore(InputField winnerName)
	{
		if(gameObject != null)
		{
			addAndRemoveScores = GetComponent<AddAndRemoveScores>();
			score = addAndRemoveScores.Score;
			StartCoroutine(EnterEndScore(score, winnerName.text));
		}

	}

	private IEnumerator EnterEndScore (int score, string playerID) {
		score_url = "http://jvdwijk.com/Games/Verbs/database.php" + "?Name=" + playerID + "&Score=" + score;
        webRequest = new WWW(score_url);
        yield return webRequest;
    }
}
