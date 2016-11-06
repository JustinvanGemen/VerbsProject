using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	[SerializeField]
	private Text[] countDownNumbers;

	// Use this for initialization
	void Start () {
		StartCoroutine (CountDownCounter());
	}

	private IEnumerator CountDownCounter()
	{
		for(int i = 0; i < countDownNumbers.Length; i++)
		{
			countDownNumbers [i].enabled = true;
			yield return new WaitForSeconds (1f);
			countDownNumbers [i].enabled = false;
		}
		StopCoroutine (CountDownCounter ());
	}
}