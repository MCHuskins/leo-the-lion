using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //player spped and jump
    public int speed = 10;
    public float jump = 0.0f;
    //Leo look at the code it is hard to explane
    public float jumpmax = 1.0008f;
    //can jump
    //public Transform ground;
    //private bool canjump = false;
    //Leo jumpi is jump increments
    public float jumpi = 0.5f;
    public float jumpi1 = 0.5f;
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
        if(jump<= jumpmax){
            jump = (jump+(Time.deltaTime * jumpi1));
        }
    }
    //this is going up leo
    if(jump>=jumpi && !(Input.GetKey(KeyCode.Space))){
        transform.Translate (Vector3. up*speed*Time.deltaTime);
        jump = (jump-(Time.deltaTime * jumpi));
        //canjump = false;
    }
    //set thing back to 0 this was need to fix the jump
    if(jump<=jumpi && !(Input.GetKey(KeyCode.Space))){
        jump=0;
    }
}
}
