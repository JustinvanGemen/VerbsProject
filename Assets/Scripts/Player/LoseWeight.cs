using UnityEngine;

namespace Player
{
	public class LoseWeight : MonoBehaviour {

		private Material _material;
		[SerializeField] private float _burntCalories;

		private void Start()
		{
			_material = gameObject.GetComponent<Renderer>().material;
		}

		private void Update()
		{
			var size = _material.GetFloat("_Amount") + _burntCalories;
			if (size < -0.03f) return;
			print(size);
			_material.SetFloat("_Amount", size);
		}
	}
}
