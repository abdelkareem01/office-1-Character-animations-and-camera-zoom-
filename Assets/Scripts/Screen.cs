using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public Material[] material;
    public int x;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[x];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = material[x];
        if(Input.GetKeyDown("k"))
        {
            x++;
        }
        if (Input.GetKeyDown("j"))
        {
            x--;
        }
    }
}
