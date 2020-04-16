using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sniper : MonoBehaviour
{
//animations
public Animator animator;
//follow
public Transform player;
public bool follow = true;
public int followspeed= 18; // how fast the snipper
public float shouldf = 0f;
public bool onplayer = false;
//right before shooting
public float swait = 0f;
//time betwwen shots
public int interval = 20;

//right before
public bool lastw = false;
public float lastc = 0f;

//shooting
public bool shooting = false;

//after shot
public float ashott = 0f;
public int tilnext = 15; //
public bool justshot = false;
    void Start(){

    }
    void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag == "Player") {
            onplayer = true;
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player") {
            onplayer = true;
        }
    }
    void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.tag == "Player"){

            onplayer = false;
        }
    }

    void Update(){
        //animations
        animator.SetBool("lastw", lastw);
        //follow section
        if(onplayer){
            shouldf += 20*Time.deltaTime;
        }
        if(!onplayer && !(shouldf>=interval)){
            shouldf = 0;
        }
        if(shouldf>=interval){
            swait += 20*Time.deltaTime;
            transform.localScale = new Vector2(6,6);
            follow = false;
        }
        if(swait>= interval){
            lastw = true;
            shouldf = 0;
            swait = 0;
        }
        if(lastw){
            lastc += 20*Time.deltaTime;
            transform.localScale = new Vector2(4,4);
            animator.SetBool("lastw", lastw);
        }
        if(lastc>= interval){
            shooting = true;
            lastc = 0;
        }
        if(shooting){
            if(onplayer){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            lastw = false;
            justshot = true;
            shooting = false;
        }
        if(justshot){
            transform.localScale = new Vector2(5,5);
            ashott += 20*Time.deltaTime;
        }
        if(ashott>= tilnext){
            follow = true;
            ashott = 0;
            justshot = false;
        }
        if (follow){
        transform.position = Vector2.MoveTowards(transform.position, player.position, followspeed*Time.deltaTime);
        }
    }
}
