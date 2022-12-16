using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    
    public AudioClip pickupEffect;
    public AudioSource source;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.PlayOneShot(pickupEffect, 6f);
            Destroy(gameObject);
        }
    }
}
