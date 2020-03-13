using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
//player current size
// public Vector2 playerS;
// public float test = 0.02f;
    void Start()
    {

    }


    void Update()
    {
        if(Input.GetKey (KeyCode.D)) {
            transform.localScale = new Vector2(1,1);
        }

        if(Input.GetKey (KeyCode.A)) {
            transform.localScale = new Vector2(-1,1);
        }
    }
}
