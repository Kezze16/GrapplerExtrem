using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPosition;

    public GameObject playerHealth;
    public GameObject healthBar;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RespawnPlayer();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            RespawnPlayer();
        }
    }

    public void RespawnPlayer()
    {
        /*player.transform.position = respawnPosition.transform.position;
        Physics.SyncTransforms();
        
        PlayerHealth ph = playerHealth.GetComponent<PlayerHealth>();
        ph.Reset();
        
        HealthBar hb = healthBar.GetComponent<HealthBar>();
        hb.SetHealth(100);*/

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
