using UnityEngine;
using System.Collections;

public class BandFoodGenerator : MonoBehaviour {

	[SerializeField]
	private GameObject[] foodSort;
	[SerializeField]
	private GameObject beltBeginning;
	private GameObject foodPlate;

	void Start ()
	{
		InvokeRepeating ("GenerateBandFood", 10f, 20f);
	}
	
	void GenerateBandFood ()
	{
		foodPlate = Instantiate(foodSort[Random.Range (0, foodSort.Length)]);
		foodPlate.transform.position = beltBeginning.transform.position;
	}
}