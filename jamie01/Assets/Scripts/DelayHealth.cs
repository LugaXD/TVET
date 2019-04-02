using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayHealth : MonoBehaviour
{

    [Header("Player Health")]
    public float maxHealth;
    public float curHealth;
    public float delayHealth;
    public float dropSpeed;
    public Slider healthBar, delayBar;
    public Image healthFill, delayFill;

    // Update is called once per frame
    void Update()
    {
        healthBar.value = Mathf.Clamp01(curHealth / maxHealth);
        if(delayHealth > curHealth)
        {
            delayHealth -= Time.deltaTime * dropSpeed;
        }
        delayBar.value = Mathf.Clamp01(delayHealth / maxHealth);
        HealthController();
    }
    void HealthController()
    {
        if (curHealth <= 0 && healthFill.enabled)
        {
            healthFill.enabled = false;
        }
        else if (!healthFill.enabled && curHealth > 0)
        {
            healthFill.enabled = true;
        }
        if (delayHealth <=0 && delayFill.enabled)
        {
            delayFill.enabled = false;
        }
        if(delayHealth < curHealth)
        {
            delayFill.enabled = true;
            delayHealth = curHealth;
            delayBar.value = healthBar.value;
        }
        curHealth = Mathf.Clamp(curHealth,0,maxHealth);
    }
}
