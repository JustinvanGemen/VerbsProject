using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	[SerializeField]
	private GameObject[] countDownNumbers;

	void Start () {
		StartCoroutine (CountDownCounter());
	}

	private IEnumerator CountDownCounter()
	{
		print ("countdown");
		for(int i = 0; i < countDownNumbers.Length; i++)
		{
			countDownNumbers [i].SetActive(true);
			yield return new WaitForSeconds (1f);
			countDownNumbers [i].SetActive(false);
		}
		StopCoroutine (CountDownCounter ());
	}
}