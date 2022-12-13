using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
   private Rigidbody rb;
   public Vector3 gravity;

   private void Start()
   {
      rb = GetComponent<Rigidbody>();
      rb.useGravity = false;
      gravity = Physics.gravity;
   }

   private void FixedUpdate()
   {
      rb.AddForce(gravity, ForceMode.Acceleration);
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.G))
      {
         ReverseGravity();
      }
   }

   private void ReverseGravity()
   {
      gravity *= -1;
   }
}
