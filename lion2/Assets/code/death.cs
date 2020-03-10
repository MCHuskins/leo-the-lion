using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    //move player back
    void OnCollisionEnter(Collision col){
            col.transform.position = new Vector3(0,0,0);
            }
}
