using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //player spped and jump
    public int speed = 10;
    public float jump = 0.0f;
    //Leo look at the code it is hard to explane
    //public Transform ground;
    private bool canjump1 = false;
    private bool canjump2 = false;
    //Leo jumpi is jump increments
    public float jumpi = 10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //left or right
        if (Input.GetKey (KeyCode.A)) {
        transform.Translate (Vector3.left*speed*Time.deltaTime);
    }
    if(Input.GetKey (KeyCode.D)) {
        transform.Translate (Vector3. right*speed*Time.deltaTime);
    }
    //jump charge
    if (Input.GetKey(KeyCode.Space)) {
        canjump1 = true;
        jump = (jump + (1*Time.deltaTime))
        }
    }
    //this is going up leo
    if(canjump1 && !(Input.GetKey(KeyCode.Space))){
        transform.Translate (Vector3.up*jumpi*Time.deltaTime);
        canjump1 = false
        //canjump = false;
    }
    //set thing back to 0 this was need to fix the jump
    if(canjump2 && !(Input.GetKey(KeyCode.Space))){
        jump=0;
    }
}
}
