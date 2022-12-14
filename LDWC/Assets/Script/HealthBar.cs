using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
  Slider healthSlider;

  private void Start()
  {
    healthSlider = GetComponent<Slider>();
  }

  public void SetMaxHealth(float maxHealth)
  {
    healthSlider.maxValue = maxHealth;
    healthSlider.value = maxHealth;
  }
  
  public void SetHealth(float currentHealth)
  {
    
    healthSlider.value = currentHealth;
  }
}
