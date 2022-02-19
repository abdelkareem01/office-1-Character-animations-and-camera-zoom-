using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour
{

    public GameObject fadeEffect;
    
    [SerializeField]
    private GameObject menuPanel;

    private bool switcher = true;

    // Start is called before the first frame update
    void Start()
    {
        fadeEffect.SetActive(true);
        menuPanel.SetActive(false);
    }

   void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            menuPanel.SetActive(switcher);
            switcher = !switcher;
        }
    }

}