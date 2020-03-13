using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    //move player back
    void OnCollisionEnter2D(Collision2D col){
            col.transform.position = new Vector2(0,0);
            Debug.Log("kill me");
            }
}
