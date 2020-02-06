using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public GameObject Flashlight;
    private bool FlashlightE = false;
    void Start()
    {

    }


    void Update()
    {
        if (FlashlightE == true)
        {
            if (Input.GetKeyDown(KeyCode.F)) 
            { 
                Flashlight.SetActive(false);
                FlashlightE = false;
                return;
            }
        }
        if (FlashlightE == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Flashlight.SetActive(true);
                FlashlightE = true;
                return;
            }
        }

        
        


        
    }
}
