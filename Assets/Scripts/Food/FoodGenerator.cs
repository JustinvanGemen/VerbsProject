using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FoodGenerator : MonoBehaviour {

	[SerializeField]
	private GameObject[] foodSort;
	[SerializeField]
	private GameObject[] spawnPoints;
	private List<GameObject> tempSpawnPoints = new List<GameObject>();
	private int plateAmount = 8;
	private GameObject foodPlate;

	void Start ()
	{
		InvokeRepeating("GenerateFood", 0f, 90f);
	}

	void GenerateFood ()
	{
		tempSpawnPoints.Clear ();

		for (int i = 0; i < spawnPoints.Length; i++) {
			tempSpawnPoints.Add (spawnPoints [i]);
		}

		for (int i = 0; i < plateAmount; i++) {
			foodPlate = Instantiate (foodSort [Random.Range (0, foodSort.Length)]);
			int number = Random.Range (0, tempSpawnPoints.Count);
			foodPlate.transform.position = tempSpawnPoints [number].transform.position;
			tempSpawnPoints.Remove (tempSpawnPoints [number]);
		}
	}
}