using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniper : MonoBehaviour
{
//follow
public Transform player;
public bool follow = true;
public int followspeed= 18;
public float shouldf = 0f;
public bool onplayer = false;
//right before shooting
public float swait = 0f;
//time betwwen shots
public int interval = 1;

//shooting
public bool shooting = false;
//after shot
public float ashott = 0f;
public int tilnext = 15;
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
        //follow section
        // isonplayer();
        if(onplayer){
            shouldf += 20*Time.deltaTime;
        }
        if(!onplayer && !(shouldf>=interval)){
            shouldf = 0;
        }
        if(shouldf>=interval){
            swait += 20*Time.deltaTime;
            follow = false;
        }
        if(swait>= interval){
            shooting = true;
            shouldf = 0;
            swait = 0;
        }
        if (shooting){
            if(onplayer){
                player.transform.position = new Vector2(0,0);
            }
            justshot = true;
            shooting = false;
        }
        if(justshot){
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
