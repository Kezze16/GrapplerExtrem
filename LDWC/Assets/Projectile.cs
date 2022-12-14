using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Projectile : MonoBehaviour
{
   [SerializeField] float damage = 10f;
   [SerializeField] private float speed = 5000f;

   private Rigidbody rb;

   private void Awake()
   {
      rb = GetComponent<Rigidbody>();
      Transform target = GameObject.FindGameObjectWithTag("Player").transform;
      Vector3 direction = target.position - transform.position;
      
      rb.AddForce(direction * speed * Time.deltaTime);
   }

   private void OnCollisionEnter(Collision collision)
   {
      if (collision.transform.tag == "Player")
      {
         PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
         playerHealth.PlayerDamage(damage);
         Destroy(gameObject);

      }
      else
      {
         Destroy(gameObject);
      }
   }
}
