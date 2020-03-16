using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniper : MonoBehaviour
{
//follow
public Vector2 playerp;
public bool follow = true;
public int followspeed= 18;

public Rigidbody2D rb;
public Transform player;

    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //follow section
        if (follow){
        transform.position = Vector2.MoveTowards(transform.position, player.position, followspeed*Time.deltaTime);
        }
    }
}
