using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementLEO : MonoBehaviour
{

    public CharacterController2D controller;


    float horizontalMove = 0f;

    public float runspeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Input.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate() {

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);

    }
}
