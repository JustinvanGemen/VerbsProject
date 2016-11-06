using UnityEngine;
using System.Collections;

public class SendScore : MonoBehaviour {
    	
	public IEnumerator EnterEndScore (int score, string playerID) {
        string score_url = "link" + "?score=" + score;
        WWW webRequest = new WWW(score_url);
        yield return webRequest;
    }
}
