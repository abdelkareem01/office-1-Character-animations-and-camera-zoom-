using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCont : MonoBehaviour
{   
    [SerializeField]
    private FirstPersonAIO fps;

    private Animator anim;

    public bool canZoom;

    void Awake() {
        anim = GetComponent<Animator>();
    }

    void Update() {
        if(Input.GetMouseButtonDown(1)){
            anim.SetBool("Zoom", true);
        }

        if(Input.GetMouseButtonUp(1)){
            anim.SetBool("Zoom", false);
        }
    }

    public void setMovement(){
        fps.playerCanMove = true;
        fps.enableCameraMovement = true;
    }

}
