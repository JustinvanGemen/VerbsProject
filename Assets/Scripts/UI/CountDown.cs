using System.Collections;
using Enemy;
using Player;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

namespace UI
{
	public class CountDown : MonoBehaviour {

		[SerializeField] private GameObject[] _countDownNumbers;
		[SerializeField] private ThirdPersonUserControl _playerInput;

		private void Start ()  
		{
			StartCoroutine (CountDownCounter());
			_playerInput.SwitchMovement = false;
		}

		private IEnumerator CountDownCounter()
		{
			foreach (var t in _countDownNumbers)
			{
				t.SetActive(true);
				yield return new WaitForSeconds (1f);
				t.SetActive(false);
			}
			_playerInput.SwitchMovement = true;
			StopCoroutine (CountDownCounter ());
		}
	}
}