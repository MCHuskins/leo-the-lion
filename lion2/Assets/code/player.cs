// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class player : MonoBehaviour
// {
//     //player spped and jump
//     public int speed = 10;
//     public float jump = 0.0f;
//     // can jump for the charge
//     public bool canjump = false;
//     public bool canjump1 = false;
//     public bool canjump2 = false;
//     //Leo jump veribales
//     public float jumphight = 5f;
//     public float jumpdown = 2f;
//     public Rigidbody rb;
//     //charge
//     public float jumpw = 1f;
//     public float jumpn = 2f;
//     public death other;
//     void Start()
//     {
//         rb = GetComponent<Rigidbody>();
//     }
//     //ground?
// void OnCollisionEnter(Collision col){
//         canjump = true;
//         if (col.gameObject.tag == "death"){
//             other.playerdeath();
//         }
//     }
//
// void OnCollisionExit (Collision col){
//         canjump = false;
//     }
//
//
//     void Update()
//     {
//         //left or right
//         if (Input.GetKey (KeyCode.A)) {
//         transform.Translate (Vector3.left*speed*Time.deltaTime);
//     }
//     if(Input.GetKey (KeyCode.D)) {
//         transform.Translate (Vector3. right*speed*Time.deltaTime);
//     }
//     //jump charge
//     if (Input.GetKey(KeyCode.Space) && canjump) {
//         canjump1 = true;
//         jump = (jump + (jumpw*Time.deltaTime));
//         if (canjump1 && jump>=jumpn){
//             canjump2 = true;
//         }
//         }
//     //jump things:
//
//     if(canjump1 && !(Input.GetKey(KeyCode.Space))){
//         rb.velocity = new Vector3(0, jumphight+2, 0);
//         canjump1 = false;
//         jump = 0;
//     }
//     if(canjump2 && !(Input.GetKey(KeyCode.Space))){
//         rb.velocity = new Vector3(0, jumphight+jumphight, 0);
//         canjump2 = false;
//         jump = 0;
//     }
// }
// }
