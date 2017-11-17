using System.Collections;
using UnityEngine;

namespace GeneralItems
{
	public class Rename : MonoBehaviour {

		[SerializeField]
		private string _nameOfObject;

		private void Start ()
		{
			gameObject.name = _nameOfObject;
		}
	}
}
