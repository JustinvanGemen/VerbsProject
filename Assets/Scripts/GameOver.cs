using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	[SerializeField]
	private SceneChanger sceneChanger;

	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Player"))
		{
			sceneChanger.ChangeScene (2);
		}
	}
}
