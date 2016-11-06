using UnityEngine;
using System.Collections;

public class AddAndRemoveScores : MonoBehaviour {
    private int score;
    public int Score { get { return score; } set { score = value; } }
	
	void Start () {
        score = 0;
	}

    public void ChangeScore(int pointsAmount)
    {
        score = score + pointsAmount;
    }	
}
