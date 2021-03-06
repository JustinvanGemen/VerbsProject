﻿using UnityEngine;

namespace GeneralItems
{
	public class ItemGenerator : MonoBehaviour {

		[SerializeField] private float _startTime;
		[SerializeField] private float _repeatTime;
		[SerializeField] private GameObject[] _itemSort;
		[SerializeField] private Transform _spawnPoint;
		[Header("Ignores at 0")]
		[SerializeField] private int _spawnTimes;

		private void Start ()
		{
			InvokeRepeating ("GenerateItem", _startTime, _repeatTime);
		}
	
		private void GenerateItem ()
		{
			Instantiate (_itemSort [Random.Range (0, _itemSort.Length)], _spawnPoint.position, Quaternion.identity);
			
			if(_spawnTimes == 0) return;
			_spawnTimes -= 1;
			if(_spawnTimes == 0) CancelInvoke();
		}
	}
}