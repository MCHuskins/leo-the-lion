using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class partollerkiller : MonoBehaviour
{
    public bool attacking;
    public GameObject player;

   void OnCollisionEnter2D(Collision2D col){
           if(col.gameObject.tag == "Player" && !(attacking)){
               col.transform.position = new Vector2(0,0);
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           }
           if(col.gameObject.tag == "Player" && (attacking)){
                Destroy(gameObject);
           }
           }

    // Update is called once per frame
    void Update()
    {
        //pulling the attac form the other the player
        GameObject player = GameObject.Find("lion");
        betterplayer pscript = player.GetComponent<betterplayer>();
        attacking = pscript.attack;


    }
}
