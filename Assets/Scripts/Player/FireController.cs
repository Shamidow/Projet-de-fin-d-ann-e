using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject co2;
    public AudioSource pshit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            co2.SetActive(true);
            pshit.Play(0);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            co2.SetActive(false);
            pshit.Play(0);
        }
    }
    
}
