using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject respawnTrigger;
    public float health = 10;

    [SerializeField] HealthBar HealthBar;

    public void PlayerDamage(float damage)
    {
        health -= damage;
        HealthBar.SetHealth(health);

        if (health <= 0)
        {

            Respawn rs = respawnTrigger.GetComponent<Respawn>();
            rs.RespawnPlayer();
            //Destroy(gameObject);
            Debug.Log("Has Destroyed ENEMEMY");
         
         
        }
    }

    public void Reset()
    {
        health = 100f;
    }
}
