using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorTrigger : MonoBehaviour
{
    public GameObject doorL;
    public GameObject doorR;

    void Start()
    {
        doorL.GetComponent<Animator>();
        doorR.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            doorR.GetComponent<Animator>().enabled = true;
            doorL.GetComponent<Animator>().enabled = true;
        }
    }
}
