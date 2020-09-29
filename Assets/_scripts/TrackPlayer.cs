using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{

    //class variables, default is private
    Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //make sure you've tagged the player object as "Player", that's how we find it
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //calculate the distance between the camera's position and the player's
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //update the position of the camera using the position of the player
        transform.position = player.position - offset;
    }
}
