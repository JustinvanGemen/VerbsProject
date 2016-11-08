using UnityEngine;
using System.Collections;

public class AddAndRemoveScores : MonoBehaviour {
    private int score;
	public int Score { get { return score; } set { score = score + value; print (score); } }
	
	void Start () {
        score = 0;
	}
}