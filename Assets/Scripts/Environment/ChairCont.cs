using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChairCont : MonoBehaviour
{
    public TextMeshProUGUI text;

    public Animator anim;

    [HideInInspector]
    public Vector3 chairCoords;
    
    [HideInInspector]
    public Vector3 chairRot;

    void start() {
    
    chairCoords = transform.position;
    chairRot = transform.eulerAngles;

    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Player")){
        text.text = "Press E to sit";
        
        }

        if(Input.GetKey(KeyCode.E)){
                        
            anim.SetBool("Sitting", true);
        }

        if(Input.GetKey(KeyCode.R)){
            anim.SetBool("Sitting", false);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag.Equals("Player")){
            text.text = "";
        }
    }

    void Update()
    {
       
    }
}
