using UnityEngine;
using System.Collections;

public class Rename : MonoBehaviour {

	[SerializeField]
	private string nameOfObject;

	void Start ()
	{
		gameObject.name = nameOfObject;
	}
}
