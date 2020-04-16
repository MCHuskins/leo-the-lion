using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathblock : MonoBehaviour
{
    //move player back
    void OnCollisionEnter2D(Collision2D col){
            if(col.gameObject.tag == "Player"){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            }
}
