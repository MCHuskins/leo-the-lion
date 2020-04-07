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
    public int speed = 10;
    // can jump for the charge
    public bool canjump = true;
    public bool canjump1 = false;
    //Leo jump veribales
    public int jumphight = 8;
    public int jumpdown = 2;
    public Rigidbody2D rb;
    //how fast you slow down
    public int friction = 5;


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
        //pushed the player down so the jump looks better
        if(rb.velocity.y<0){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (jumpdown*1)*Time.deltaTime;
        }
        //turing the animation
        moving = rb.velocity.x;
        animator.SetFloat("speed", Mathf.Abs(moving));
        //moving Left
        if (Input.GetKey (KeyCode.A)) {
        rb.velocity = new Vector2(speed*-1, rb.velocity.y);
    }
        //moving Right
    if(Input.GetKey (KeyCode.D)) {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    //jump
    if(canjump && (Input.GetKey(KeyCode.W))){
        rb.velocity = new Vector2(rb.velocity.x, jumphight+jumphight);
    }
    // slowing you down when you stop moving so friction
    if(canjump){
        if(!(Input.GetKey(KeyCode.D))){
            if(rb.velocity.x >=5){
                rb.velocity = new Vector2(rb.velocity.x-friction, rb.velocity.y);
            }
            }
        if(!(Input.GetKey(KeyCode.D))){
            if(rb.velocity.x <=-5){
                rb.velocity = new Vector2(rb.velocity.x+friction, rb.velocity.y);
            }
        }
    }
}
}
