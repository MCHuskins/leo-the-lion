using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wdetection : MonoBehaviour
{
    
    public float distance;

    private bool movingRight = true;

    public Transform wdetect;

    private void Update()
    {

        
        RaycastHit2D winfo = Physics2D.Raycast(wdetect.position, Vector2.down, distance);

        if (winfo.collider == true)
        {
            if (movingRight == true)
            {

                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;

            }
            else
            {

                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;

            }
        }
    }
}
