using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextFadeAnimation : MonoBehaviour {

	private Text text;
	private Color colorOfImage;

	void Start()
	{
		OnEnable ();
	}

	void OnEnable()
	{
		text = GetComponent<Text> ();
		colorOfImage = text.color;
		colorOfImage.a = 1;
		text.color = colorOfImage;
		StartCoroutine(FadeDelay());
	}

	private IEnumerator FadeDelay(){
		while(text.color.a > 0)
		{
			colorOfImage.a -= 0.05f;
			text.color = colorOfImage;
			yield return new WaitForSeconds(0.1f); 	
		}
		StopCoroutine(FadeDelay());
	}
}
