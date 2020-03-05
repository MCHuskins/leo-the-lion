using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//leo this is the camera code
public class cam : MonoBehaviour
{
    public Transform player;
//zoom of the camera
    public int zoom = -11;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (player.position.x, player.position.y, zoom);
    }
}
