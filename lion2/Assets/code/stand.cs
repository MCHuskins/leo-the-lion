using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stand : MonoBehaviour
{
public bool sstand = true;

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "block"){
            sstand = false;
        }
    }
    void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.tag == "block"){
            sstand = true;
        }
    }
}
