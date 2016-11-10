using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FoodGenerator : MonoBehaviour {

	[SerializeField]
	private GameObject[] foodSort;
	[SerializeField]
	private List<GameObject> spawnPoints = new List<GameObject>();
	private List<GameObject> tempSpawnPoints = new List<GameObject>();
	private int plateAmount = 7;
	private GameObject foodPlate;

	void Start ()
	{
		InvokeRepeating("GenerateFood", 0f, 90f);
	}

	void GenerateFood ()
	{
		tempSpawnPoints = spawnPoints;
		for (int i = 0; i < plateAmount; i++) {
			foodPlate = Instantiate(foodSort[Random.Range (0, foodSort.Length)]);
			int number = Random.Range (0, tempSpawnPoints.Count);
			foodPlate.transform.position = tempSpawnPoints [number].transform.position;
			tempSpawnPoints.Remove (tempSpawnPoints [number]);
		}
	}
}
