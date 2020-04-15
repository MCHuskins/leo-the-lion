using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag == "Player") {
            SceneManager.LoadScene("level0");
        }
    }
}
