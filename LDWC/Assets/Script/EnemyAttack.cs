using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
   [SerializeField] private GameObject projectile;
   [SerializeField] private Transform shootPoint;

   [SerializeField] private float turnSpeed = 5;
   
   private Transform target;

   public float rate;

   private float fireRate = 0.5f;


   private void Start()
   {
      target = GameObject.FindGameObjectWithTag("Player").transform;
   }

   private void Update()
   {
      fireRate -= Time.deltaTime;

      Vector3 direction = target.position - transform.position;
      transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.deltaTime);
      
      

      if (fireRate <= 0)
      {
         fireRate = rate; 
         Shoot();
      }
   }

   void Shoot()
   {
      Instantiate(projectile, shootPoint.position, shootPoint.rotation);

   }
}
