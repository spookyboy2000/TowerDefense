using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	[SerializeField] private Slider slider;
	[SerializeField] private Gradient gradient;
	[SerializeField] private Image fill;

	public void SetMaxHealth(int currentHealth)
	{
		slider.maxValue = currentHealth;
		slider.value = currentHealth;

		//fill.color = gradient.Evaluate(1f);
	}

	public void SetHealth(int currentHealth)
	{
		slider.value = currentHealth;

		//fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}
