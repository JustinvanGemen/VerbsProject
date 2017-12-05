using System.Collections;
using Enemy;
using Player;
using UnityEngine;

namespace UI
{
	public class CountDown : MonoBehaviour {

		[SerializeField] private GameObject[] _countDownNumbers;
		[SerializeField] private PlayerInputController _playerInput;
		[SerializeField] private EnemyMovement _enemyInput;

		private void Start () {
			StartCoroutine (CountDownCounter());
			_playerInput.SwitchMovement = false;
			_enemyInput.SwitchMovement = false;
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
			_enemyInput.SwitchMovement = true;
			StopCoroutine (CountDownCounter ());
		}
	}
}