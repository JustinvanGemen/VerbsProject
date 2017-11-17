using UnityEngine;

namespace GeneralItems
{
	public class DestroyObject : MonoBehaviour {

		[SerializeField]
		private float _counter;

		private void Start ()
		{
			Invoke ("Destroy", _counter);
		}

		private void Destroy ()
		{
			Destroy (gameObject);
		}
	}
}
