using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterplayer : MonoBehaviour
{
    //character
    public Animator animator;
    public float moving = 0.0f;
    public bool crouching = false;
    //player spped and jump
    public int speed = 2;
    public int speedmax= 20;
    // can jump for the charge
    public bool canjump = true;
    //Leo jump veribales
    public int jumphight = 10;
    public int jumpdown = 6;
    private Rigidbody2D rb;
    //how fast you slow down
    public int friction = 8;
    //crouch
    public int chargejumphigt = 5;
    public int charge;
    private float chargecount;
    public int chargemax = 24;
    public int nextcharge = 5;
    public int chargespeed = 6;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //ground?
    void OnCollisionEnter2D(Collision2D col){
            canjump = true;
            }

    void OnCollisionExit2D(Collision2D col){
            canjump = false;
        }


    void Update()
    {

        //moving Left
    if(Input.GetKey(KeyCode.A)) {
        if(-1*moving <= speedmax){
            rb.velocity = new Vector2(rb.velocity.x-speed, rb.velocity.y);
        }
    }
        //moving Right
    if(Input.GetKey(KeyCode.D)) {
        if(moving <= speedmax){
            rb.velocity = new Vector2(rb.velocity.x+speed, rb.velocity.y);
        }
    }
    //jump
    if(canjump && (Input.GetKey(KeyCode.Space)) && !(crouching)){
        rb.velocity = new Vector2(rb.velocity.x, jumphight+jumphight);
    }
    //crouch/ charge jump
    if(canjump && Input.GetKey(KeyCode.S)){
       crouching = true;
       speedmax = chargespeed;
       chargecount += 10*Time.deltaTime;
       if(chargecount >= nextcharge && charge <= chargemax){
           charge += 8;
           nextcharge += 5;
       }
   }
   if(crouching && !(Input.GetKey(KeyCode.S))){
       speedmax = 20;
       crouching = false;
       rb.velocity = new Vector2(rb.velocity.x, jumphight+charge);
       charge = 0;
       chargecount = 0;
       nextcharge = 5;
   }
    // slowing you down when you stop moving so friction unless you are in the air
    if(canjump){
        if(!(Input.GetKey(KeyCode.D))){
            if(rb.velocity.x >=5){
                rb.velocity = new Vector2(rb.velocity.x-friction, rb.velocity.y);
            }
            }
        if(!(Input.GetKey(KeyCode.A))){
            if(rb.velocity.x <=-5){
                rb.velocity = new Vector2(rb.velocity.x+friction, rb.velocity.y);
            }
        }
    }
    //pushed the player down so the jump looks better
    if(rb.velocity.y<0){
        rb.velocity += Vector2.up * Physics2D.gravity.y * (jumpdown*1)*Time.deltaTime;
    }
    //turing the animation
    moving = rb.velocity.x;
    animator.SetFloat("speed", Mathf.Abs(moving));
    //animator.SetBool("crouching", crouching)

}
}
