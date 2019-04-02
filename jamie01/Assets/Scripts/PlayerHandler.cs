using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public DelayHealth health;
    public bool hurt = false, check = false;
    public float difference;
    public Transform curCheckPoint;

    private void Start()
    {
        health = this.GetComponent<DelayHealth>();
    }
    //Damage Collision

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Damage"))
        {
            hurt = true;
        }
    }
    //Heal Trigger

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Heal"))
        {
            health.curHealth += Time.deltaTime * 5;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CheckPoint"))
        {
            curCheckPoint = other.transform;
        }
    }

    private void Update()
    {
        if (hurt)
        {
            if (!check)
            {
                difference = health.curHealth - 25;
                check = true;
            }
            if (health.curHealth > difference)
            {
                health.curHealth -= 25 * Time.deltaTime;
            }
            else
            {
                hurt = false;
                check = false;
            }
        }
        if(health.curHealth <= 0)
        {
            this.transform.position = curCheckPoint.position;
            health.curHealth = health.maxHealth;
        }
    }
}
