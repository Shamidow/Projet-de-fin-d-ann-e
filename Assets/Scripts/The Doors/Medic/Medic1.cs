using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic1 : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>(); // Prendre l'animator        
    }

    // Update is called once per frame
    void Update()
    {


        // On prends le raycast dans le raycast perso, on l'utilise pour trigger le triger bouger
        if (RaycastPerso.getMedic1 == true)
        {
            // Ici présent 
            m_Animator.SetTrigger("Medic");
        }

    }
}
