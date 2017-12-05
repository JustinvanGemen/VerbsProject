using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class ImageFadeAnimation : MonoBehaviour {

		private Image _image;
		private Color _colorOfImage;

		private void Start()
		{
			OnEnable ();
		}

		private void OnEnable()
		{
			_image = GetComponent<Image> ();
			_colorOfImage = _image.color;
			_colorOfImage.a = 0;
			_image.color = _colorOfImage;
			StartCoroutine(FadeDelay());
		}

		private IEnumerator FadeDelay(){
			while(_image.color.a < 1)
			{
				_colorOfImage.a += 0.1f;
				_image.color = _colorOfImage;
				yield return new WaitForSeconds(0.1f); 	
			}
			StopCoroutine(FadeDelay());
		}
	}
}
