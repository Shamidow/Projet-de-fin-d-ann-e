using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BureauB : MonoBehaviour
{
    Animator m_Animator;
    public GameObject doc;
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>(); // Prendre l'animator        
    }

    // Update is called once per frame
    void Update()
    {


        // On prends le raycast dans le raycast perso, on l'utilise pour trigger le triger bouger et active le trigger du doc du lore
        if (RaycastPerso.getDoorbureaub == true)
        {
            // Ici présent 
            m_Animator.SetTrigger("Autre");
            Invoke("Activate", 1f);
        }

    }
    public void Activate()
    {
        doc.SetActive(true);
    }
}
