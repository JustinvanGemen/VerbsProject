using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class ImageSlider : MonoBehaviour {

		[SerializeField] private GameObject[] _images;
		[SerializeField] private Slider _slider;

		private int _counter = 0;

		private void Start ()
		{
			StartCoroutine ("AutoScroller");
		}

		public void Backwards()
		{
			_counter--;

			if(_counter < 0)
			{
				_counter = _images.Length - 1;
			}
			DisableImages ();
		}

		public void Forwards()
		{
			_counter++;

			if(_counter > _images.Length -1)
			{
				_counter = 0;
			}
			DisableImages ();
		}

		private void DisableImages()
		{
			for (var i = 0; i < _images.Length; i++)
			{
				_images [i].SetActive(false);
				if(i != _counter) continue;
				_images [i].SetActive(true);
			}
		}

		private IEnumerator AutoScroller(){
			while (true) {
				yield return new WaitForSeconds (5f);
				Forwards ();
			}
		}
	}
}