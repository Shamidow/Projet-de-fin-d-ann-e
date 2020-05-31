using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressanykey : MonoBehaviour
{
    public GameObject menu;
    public GameObject start;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            start.SetActive(false);
            menu.SetActive(true);
        }
    }
}
