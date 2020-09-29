using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNextRing : MonoBehaviour
{
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //i've now changed the file!

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            next.SetActive(true);
        }
    }
}
