﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterplayer : MonoBehaviour
{
    //player spped and jump
    public int speed = 10;
    // can jump for the charge
    public float jump = 0.0f;
    public bool canjump = true;
    public bool canjump1 = false;
    public int jumpi = 0;
    //Leo jump veribales
    public float jumphight = 3f;
    public float jumpdown = 2f;
    public Rigidbody rb;
    //charge
    public float jumpw = 1f;
    public float jumpn = 2f;
    public int jumpmax = 3;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //ground?
void OnCollisionEnter(Collision col){
        canjump = true;
    }

void OnCollisionExit (Collision col){
        canjump = false;
    }
    // Update is called once per frame
    void Update()
    {
        //left or right
        if (Input.GetKey (KeyCode.A)) {
        rb.velocity = new Vector3(speed*-1, 0, 0);
    }
    if(Input.GetKey (KeyCode.D)) {
        rb.velocity = new Vector3(speed, 0,0);
    }
    //dowm
    if(rb.velocity.y<0){
        rb.velocity += Vector3.up * Physics2D.gravity.y * (jumpdown*1)*Time.deltaTime;
    }
    //jump charge
    if (Input.GetKey(KeyCode.Space) && canjump) {
        canjump1 = true;
        jump = (jump + (jumpw*Time.deltaTime));
        if (jumpi+1<=jump && !(jumpi>jumpmax)){
            jumpi = jumpi+1;
        }
        }
    //jump things:

    if(canjump1 && !(Input.GetKey(KeyCode.Space))){
        rb.velocity = new Vector3(0, jumphight+2, 0);
        canjump1 = false;
        jump = 0;
    }
    if(jumpi>=1 && !(Input.GetKey(KeyCode.Space))){
        rb.velocity = new Vector3(0, jumphight+jumphight*jumpi, 0);
        jump = 0;
        jumpi =0;
    }
}
}
