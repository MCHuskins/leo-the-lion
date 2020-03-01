using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //player spped and jump
    public int speed = 10;
    public int jump = 0;
    //Leo look at the code it is hard to explane
    public int jumpmax = 1000;
    //can jump
    //public Transform ground;
    //private bool canjump = false;
    //Leo jumpi is jump increments
    public int jumpi = 30;
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
    //jump
    if (Input.GetKey(KeyCode.Space)) {
        if(jump<= jumpmax){
            jump = jump+ jumpi;}
    }
    if(jump>=jumpi && !(Input.GetKey(KeyCode.Space))){
        transform.Translate (Vector3. up*jumpi*Time.deltaTime);
        jump = jump - jumpi;
        //canjump = false;
    }
}
}
