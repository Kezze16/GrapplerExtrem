using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 10;

    [SerializeField] HealthBar HealthBar;

    public void PlayerDamage(float damage)
    {
        health -= damage;
        HealthBar.SetHealth(health);

        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Has Destroyed ENEMEMY");
         
         
        }
    }
}
