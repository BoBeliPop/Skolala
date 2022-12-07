using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThePissScript : MonoBehaviour
{

    private string name = "Erwin";
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            print("Update");
        }
    }
}
