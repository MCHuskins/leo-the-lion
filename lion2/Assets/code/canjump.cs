using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canjump : MonoBehaviour
{
    // public static int jumpi; //how high a player can jump
    // Text text;
    // void Start()
    // {
    //     text = GetComponent<Text>();
    //     jumpi = 0;
    // }

    // void Update()
    // {
    //     text.text = "Jump hight: "+ jumpi;
    // }
public int jumptest = 1;
    void OnGUI()
    {
        GUILayout.Label("score"+jumptest);;
    }
}
