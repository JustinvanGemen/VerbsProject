using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour {

	[SerializeField]
	private float startTime;
	[SerializeField]
	private float repeatTime;
	[SerializeField]
	private GameObject[] itemSort;
	[SerializeField]
	private Transform spawnPoint;
	private GameObject item;

	void Start ()
	{
		InvokeRepeating ("GenerateItem", startTime, repeatTime);
	}
	
	private void GenerateItem ()
	{
		Instantiate (itemSort [Random.Range (0, itemSort.Length)], spawnPoint.position);
		//item.transform.position = spawnPoint.transform.position;  
		//spawnPoint.gameObject.transform.position Quaternion.identity
	}
}