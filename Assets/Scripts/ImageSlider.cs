using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageSlider : MonoBehaviour {

	[SerializeField]
	private GameObject[] images;

	[SerializeField]
	private Slider slider;

	private int counter = 0;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine ("AutoScroller");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Backwards()
	{
		counter--;

		if(counter < 0)
		{
			counter = images.Length - 1;
		}
		DisableImages ();
	}

	public void Forwards()
	{
		counter++;

		if(counter > images.Length -1)
		{
			counter = 0;
		}
		DisableImages ();
	}

	private void DisableImages()
	{
		for (int i = 0; i < images.Length; i++)
		{
			images [i].SetActive(false);

			if(i == counter)
			{
				images [i].SetActive(true);
			}
		}
	}

	IEnumerator AutoScroller(){
		while (true) {
			yield return new WaitForSeconds (5f);
			Forwards ();
		}
	}
}
