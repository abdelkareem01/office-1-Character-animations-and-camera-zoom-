using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3(91f, 5, -4f);
        }
    }
}
