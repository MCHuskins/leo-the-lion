using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //player spped and jump
    public int speed = 10;
    public float jump = 0.0f;
    // can jump for the charge
    public bool canjump = false;
    public bool canjump1 = false;
    public bool canjump2 = false;
    //Leo jump veribales
    public float jumphight = 5f;
    public float jumpdown = 2f;
    public Rigidbody rb;
    //charge
    public float jumpw = 1f;
    public float jumpn = 2f;
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
        transform.Translate (Vector3.left*speed*Time.deltaTime);
    }
    if(Input.GetKey (KeyCode.D)) {
        transform.Translate (Vector3. right*speed*Time.deltaTime);
    }
    //jump charge
    if (Input.GetKey(KeyCode.Space) && canjump) {
        canjump1 = true;
        jump = (jump + (jumpw*Time.deltaTime));
        if (canjump1 && jump>=jumpn){
            canjump2 = true;
        }
        }
    //jump things:
    // if (rb.velocity.y < 0) {
    //     rb.velocity = Vector3.up*Physics2D.gravity*jumpdown*Time.deltaTime;
    // }
    if(canjump1 && !(Input.GetKey(KeyCode.Space))){
        rb.velocity = new Vector3(0, jumphight+2, 0);
        canjump1 = false;
        jump = 0;
    }
    //set thing back to 0 this was need to fix the jump
    if(canjump2 && !(Input.GetKey(KeyCode.Space))){
        rb.velocity = new Vector3(0, jumphight+jumphight, 0);
        canjump2 = false;
        jump = 0;
    }
}
}
