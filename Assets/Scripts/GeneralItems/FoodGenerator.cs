using System.Collections.Generic;
using UnityEngine;

namespace GeneralItems
{
	public class FoodGenerator : MonoBehaviour {

		[SerializeField] private GameObject[] _foodSort;
		[SerializeField] private GameObject[] _spawnPoints;
		[SerializeField] private const int MaxPlateAmount = 30;
		private readonly List<GameObject> _tempSpawnPoints = new List<GameObject>();
		private GameObject _foodPlate;

		private void Start ()
		{
			InvokeRepeating("GenerateFood", 0f, 90f);
		}

		private void GenerateFood ()
		{
			_tempSpawnPoints.Clear ();

			foreach (var t in _spawnPoints)
			{
				_tempSpawnPoints.Add (t);
			}

			for (var i = 0; i < MaxPlateAmount; i++) {
				_foodPlate = Instantiate (_foodSort [Random.Range (0, _foodSort.Length)]);
				var number = Random.Range (0, _tempSpawnPoints.Count);
				_foodPlate.transform.position = _tempSpawnPoints [number].transform.position;
				_tempSpawnPoints.Remove (_tempSpawnPoints [number]);
			}
		}
	}
}