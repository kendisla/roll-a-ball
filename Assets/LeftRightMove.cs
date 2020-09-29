using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightMove : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.RotateAround(player.transform.position, Vector3.up, 90);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.RotateAround(player.transform.position, Vector3.up, -90);
        }
    }
}
