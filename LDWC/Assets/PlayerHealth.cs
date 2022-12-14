using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 10;

    public void PlayerDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Has Destroyed ENEMEMY");
         
         
        }
    }
}
