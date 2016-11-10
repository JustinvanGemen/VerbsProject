using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	[SerializeField]
	private float counter;

	void Start ()
	{
		Invoke ("DestroyIt", counter);
	}
	
	// Update is called once per frame
	void DestroyIt ()
	{
		Destroy (gameObject);
	}
}
