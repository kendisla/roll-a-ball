using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    Vector3 respawn;
    public GameObject ring1;
    public GameObject ring2;
    public GameObject ring3;

    public GameObject stairs;
    public GameObject hole;
    public GameObject uDidIt;

    // Start is called before the first frame update
    void Start()
    {
        respawn = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            other.gameObject.transform.position = respawn;
            Reset();
        }
    }

    void Reset()
    {
        ring1.SetActive(false);
        ring2.SetActive(false);
        ring3.SetActive(false);
        stairs.SetActive(false);
        hole.SetActive(false);
        uDidIt.SetActive(false);
    }
}
