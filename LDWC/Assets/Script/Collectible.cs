using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip pickupEffect;
    public AudioSource source;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            source.PlayOneShot(pickupEffect, 0.7f);
            Collected(other);
        }
    }

    void Collected(Collider player)
    {
        Debug.Log("Health Boost");



        Destroy(gameObject);

        // spawn cool effect
        // apply effect

    }
}
