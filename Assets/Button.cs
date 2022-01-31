using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour{
    public void playgame(){
        SceneManager.LoadScene("SampleScene");
        Debug.Log("asdkjfhf");
    }

    public void quitgame(){
        Application.Quit();
         Debug.Log("asdkjfhf");
    }
}
