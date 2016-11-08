using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SendScore : MonoBehaviour {
    	
	private AddAndRemoveScores addAndRemoveScores;
	private int score;

	public void EnterScore(InputField winnerName)
	{
		Debug.Log(winnerName.text);
		if(gameObject != null)
		{
			addAndRemoveScores = GetComponent<AddAndRemoveScores>();
			score = addAndRemoveScores.Score;
			score = Mathf.Round(score);
			StartCoroutine(EnterEndScore(score, winnerName.text));
		}

	}

	public IEnumerator EnterEndScore (int score, string playerID) {
		string score_url = "http://jvdwijk.com/Games/Verbs/database.php" + "?id=" + playerID + "&score=" + score;
        WWW webRequest = new WWW(score_url);
        yield return webRequest;
    }
}
