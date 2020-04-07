using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterplayer : MonoBehaviour
{
    //character
    public Animator animator;
    public float test = 0.0f;
    //player spped and jump
    public int speed = 10;
    // can jump for the charge
    public float jump = 0.0f;
    public bool canjump = true;
    public bool canjump1 = false;
    public int jumpi = 0;
    //Leo jump veribales
    public float jumphight = 8f;
    public float jumpdown = 2f;
    public Rigidbody2D rb;
    //charge
    public float jumpw = 15f;
    public float jumpn = 2f;
    public int jumpmax = 3;


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
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(test));
        test = rb.velocity.x;
        //left or right
        if (Input.GetKey (KeyCode.A)) {
        rb.velocity = new Vector2(speed*-1, rb.velocity.y);
    }
    if(Input.GetKey (KeyCode.D)) {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    //dowm
    if(rb.velocity.y<0){
        rb.velocity += Vector2.up * Physics2D.gravity.y * (jumpdown*1)*Time.deltaTime;
    }
    //jump
    if(canjump && (Input.GetKey(KeyCode.Space))){
        rb.velocity = new Vector2(rb.velocity.x, jumphight+jumphight);
    }

    if(canjump){
        if(!(Input.GetKey(KeyCode.D))){
            if(rb.velocity.x >=5){
                rb.velocity = new Vector2(rb.velocity.x-5, rb.velocity.y);
            }
            }
        if(!(Input.GetKey(KeyCode.D))){
            if(rb.velocity.x <=-5){
                rb.velocity = new Vector2(rb.velocity.x+5, rb.velocity.y);
            }
        }
    }
}
}
