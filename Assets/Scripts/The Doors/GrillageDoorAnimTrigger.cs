﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillageDoorAnimTrigger : MonoBehaviour
{
    Animator m_Animator;
    private bool Voiceline = false;
    // Start is called before the first frame update
    void Start()
    {
        // Prendre l'animator 
        m_Animator = gameObject.GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {


        // On prends le raycast dans le raycast perso, on l'utilise pour trigger le triger bouger
        if (CloudScript.firstclose == true)
        {
            m_Animator.SetTrigger("FirstClose");
            FindObjectOfType<AudioManager>().Play("Grid");
            CloudScript.firstclose = false;
        }

        if (RaycastPerso.getDoorGrillage == true)
        {
            if (Keypad.PowerGoodCode == true)
            {
                // Ici présent 
                m_Animator.SetTrigger("Open");
                FindObjectOfType<AudioManager>().Play("Open Grid");
                RaycastPerso.getDoorGrillage = false;
            }

            else
            {
                FindObjectOfType<AudioManager>().Play("Locked Grid");
                
                Debug.Log("joue zebi");
                RaycastPerso.getDoorGrillage = false;
                if(Voiceline == false)
                {
                    FindObjectOfType<AudioManager>().Play("VGrille Locked");
                    Voiceline = true;
                }

            }
        }
        
    }

}


