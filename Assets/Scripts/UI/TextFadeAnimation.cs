using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class TextFadeAnimation : MonoBehaviour {

		private Text _text;
		private Color _colorOfImage;

		private void Start()
		{
			OnEnable ();
		}

		private void OnEnable()
		{
			_text = GetComponent<Text> ();
			_colorOfImage = _text.color;
			_colorOfImage.a = 1;
			_text.color = _colorOfImage;
			StartCoroutine(FadeDelay());
		}

		private IEnumerator FadeDelay(){
			while(_text.color.a > 0)
			{
				_colorOfImage.a -= 0.05f;
				_text.color = _colorOfImage;
				yield return new WaitForSeconds(0.1f); 	
			}
			StopCoroutine(FadeDelay());
		}
	}
}
