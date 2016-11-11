using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	[SerializeField]
	private float counter;

	void Start ()
	{
		Invoke ("DestroyIt", counter);
	}

	private void DestroyIt ()
	{
		Destroy (gameObject);
	}
}
