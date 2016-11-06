using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	[SerializeField]
	private GameObject[] countDownNumbers;
	[SerializeField]
	private PlayerInputController playerInput;
	[SerializeField]
	private EnemyMovement enemyInput;

	void Start () {
		StartCoroutine (CountDownCounter());
		playerInput.SwitchMovement = false;
		enemyInput.SwitchMovement = false;
	}

	private IEnumerator CountDownCounter()
	{
		for(int i = 0; i < countDownNumbers.Length; i++)
		{
			countDownNumbers [i].SetActive(true);
			yield return new WaitForSeconds (1f);
			countDownNumbers [i].SetActive(false);
		}
		playerInput.SwitchMovement = true;
		enemyInput.SwitchMovement = true;
		StopCoroutine (CountDownCounter ());
	}
}