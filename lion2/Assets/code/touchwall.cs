using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchwall : MonoBehaviour
{


    
    public float distance;

    private bool movingRight = true;

    public Transform wallDetection;

    void Update()
    {

        

        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetection.position, Vector2.down, distance);
        if (wallInfo.collider == true)
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



