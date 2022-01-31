using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChairCont : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    
    [SerializeField]
    private Animator playerAnim;

    [SerializeField]
    private GameObject player;
    
    private Animator chairAnim;
    private bool canSit = false;
    [SerializeField]
    private FirstPersonAIO fps;

    [SerializeField]
    private Animator CameraAnim;

    [SerializeField]
    private Camera camera;
    void Awake() {
       
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Player")){
        text.text = "Press E to sit";
        
        canSit = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag.Equals("Player")){
            text.text = "";
         
         canSit = false;    
        }
    }

    void Update() {
        
        float y = player.transform.rotation.eulerAngles.y;
      
        
        if(Input.GetKeyDown(KeyCode.E) && canSit){
            chairAnim = GetComponent<Animator>();
            camera.transform.rotation = Quaternion.Euler(85,0,0);            
            fps.enableCameraMovement = false;
            fps.playerCanMove = false;
            fps.canZoom = true;
            playerAnim.SetBool("Sitting", true);
            chairAnim.SetTrigger("Move");
            CameraAnim.SetBool("Move", true);
            CameraAnim.SetBool("Return", false);
            player.transform.position = this.transform.position + new Vector3(0,-0.2f,0);
            player.transform.rotation = Quaternion.Euler(0, y, 0);
            canSit = false;
            Debug.Log(y);
        }

        if(Input.GetKeyDown(KeyCode.Mouse1)){
           fps.enableCameraMovement = true;     
        }


        if(Input.GetKeyDown(KeyCode.R) && !canSit){
            fps.enableCameraMovement = false;
            chairAnim = GetComponent<Animator>();
            CameraAnim.SetBool("Move", false);
            playerAnim.SetBool("Sitting", false);
            CameraAnim.SetBool("Return", true);
            chairAnim.SetTrigger("Move");
            player.transform.rotation = Quaternion.Euler(0, y, 0);
        }
    }

}
