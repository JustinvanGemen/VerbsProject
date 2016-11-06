using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImageFadeAnimation : MonoBehaviour {

	private Image image;
	private Color colorOfImage;

	void Start()
	{
		OnEnable ();
	}

	void OnEnable()
	{
		image = GetComponent<Image> ();
		colorOfImage = image.color;
		colorOfImage.a = 0;
		image.color = colorOfImage;
		StartCoroutine(FadeDelay());
	}

	private IEnumerator FadeDelay(){
		while(image.color.a < 1)
		{
			colorOfImage.a += 0.1f;
			image.color = colorOfImage;
			yield return new WaitForSeconds(0.1f); 	
		}
		StopCoroutine(FadeDelay());
	}
}
