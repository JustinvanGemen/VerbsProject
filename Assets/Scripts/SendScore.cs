using UnityEngine;
using System.Collections;

public class SendScore : MonoBehaviour {
    	
	public IEnumerator EnterEndScore (int score, string playerID) {

        string score_url = "link" + "?score=" + score;
        WWW webRequest = new WWW(score_url);
        yield return webRequest;

        if (webRequest.text != "")
        {
            Debug.Log("PHP Success: " + webRequest.text);
        }
        else
        {
            Debug.Log("PHP Fail ");
        }
    }
}
