﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillageDoorAnimTrigger : MonoBehaviour
{
    Animator m_Animator;
    public AudioSource dooropening;
    public AudioSource lockeddoor;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>(); // Prendre l'animator        
    }

    // Update is called once per frame
    void Update()
    {


        // On prends le raycast dans le raycast perso, on l'utilise pour trigger le triger bouger
        if (CloudScript.firstclose == true)
        {
            m_Animator.SetTrigger("FirstClose");
            CloudScript.firstclose = false;
        }

        if (RaycastPerso.getDoorGrillage == true)
        {
            if (Keypad.PowerGoodCode == true)
            {
                // Ici présent 
                m_Animator.SetTrigger("Open");
                dooropening.Play(0);
                RaycastPerso.getDoorGrillage = false;
            }

            else
            {
                lockeddoor.Play(0);
                RaycastPerso.getDoorGrillage = false;
            }
        }
        
    }

}


