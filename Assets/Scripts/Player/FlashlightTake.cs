﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightTake : MonoBehaviour
{
    public GameObject lampetorche;
    public static bool torche;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag =="Player" && Input.GetKeyDown(KeyCode.E))
        {
            FlashlightController.isactive = true;
            lampetorche.SetActive(true);
            torche = true;
            Destroy(gameObject);
        }
    }
}
