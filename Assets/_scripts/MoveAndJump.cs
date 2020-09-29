using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndJump : MonoBehaviour
{
    //class variables
    private Rigidbody rb;
    public float speed = 4f;
    bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey returns true if the key is being pressed down during that frame
        if (Input.GetKey(KeyCode.W))
        {
            //the Rigidbody component has a method called AddForce, use this to push the player where you want to go 
            //   the method takes a Vector3 (x,y,z) in the direction to add the force
            rb.AddForce(new Vector3(1, 0, 0) * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(-1, 0, 0) * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(0, 0, 1) * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0, 0, -1) * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            rb.AddForce(new Vector3(0, 100, 0) * speed);
            jumping = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.tag.Equals("floor")){
            jumping = false;
        }
    }
}
