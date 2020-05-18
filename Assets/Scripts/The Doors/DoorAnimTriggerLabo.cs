using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimTriggerLabo : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Set Door Anim");
        m_Animator = gameObject.GetComponent<Animator>(); // Prendre l'animator        
    }

    // Update is called once per frame
    void Update()
    {
        

        // On prends le raycast dans le raycast perso, on l'utilise pour trigger le triger bouger
        if (InshallahRaycast.getDoorLabo == true)
        {
            // Ici présent 
            m_Animator.SetTrigger("Autre");
            Debug.Log("SetTrigger");
            InshallahRaycast.getDoorLabo = false;
        }

    }

}
       
    
