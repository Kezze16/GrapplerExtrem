using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    
    public GameObject endScreen;
    public TMP_Text timerText;
    private bool timerStart = false;

    private float currentTime;
    private float startTime = 5;
    
    public AudioClip pickupEffect;
    public AudioSource source;

    private void Start()
    {
        endScreen.SetActive(false);
        currentTime = startTime;
        timerText.text = currentTime.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EndLevel();
            
        }
    }

    private void Update()
    {
        if (timerStart)
        {
            currentTime -= Time.deltaTime;
            
            timerText.text = currentTime.ToString("f1");
            
            if (currentTime <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    void EndLevel()
    {
        source.PlayOneShot(pickupEffect, 6f);
        endScreen.SetActive(true);
        timerStart = true;
        
    }
}
