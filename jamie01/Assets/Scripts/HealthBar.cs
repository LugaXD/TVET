using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [Header("Player Health")]
    public float maxHealth;
    public float curHealth;
    public Slider healthBar;
    public Image healthFill;
	
	// Update is called once per frame
	void Update ()
    {
        healthBar.value = Mathf.Clamp01(curHealth / maxHealth);
        if (curHealth <= 0 && healthFill.enabled)
        {
            healthFill.enabled = false;
        }
        else if (!healthFill.enabled && curHealth >0)
        {
            healthFill.enabled = true;
        }
	}
}
