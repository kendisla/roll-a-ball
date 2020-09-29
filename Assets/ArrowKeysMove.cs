using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeysMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 4f;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * speed);
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-Vector3.forward * speed);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(-Vector3.left * speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("boost"))
        {
            speed = speed * 2;
            StartCoroutine(SpeedUp());
            Destroy(other.gameObject);
        }
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(5f);
        speed = speed / 2;
    }
}
