using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderChanger : MonoBehaviour {

	[SerializeField]
	private ImageSlider imageSlider;
	private Slider slider;

	private float newSliderValue;
	private float oldSliderValue;

	void Start ()
	{
		slider = GetComponent<Slider> ();
	}

	public void ValueChange ()
	{
		newSliderValue = slider.value;
		if(newSliderValue > oldSliderValue)
		{
			imageSlider.Forwards ();
		}
		else if(newSliderValue < oldSliderValue)
		{
			imageSlider.Backwards ();
		}
		oldSliderValue = newSliderValue;
	}
}
