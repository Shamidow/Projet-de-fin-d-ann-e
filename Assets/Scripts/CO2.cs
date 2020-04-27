using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CO2 : MonoBehaviour
{
    public GameObject extincteur;
    public GameObject empty;
    public GameObject auEx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            extincteur.SetActive(false);
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            auEx.SetActive(true);
            auEx.transform.parent = null;
            ;
            ;
            ;
            ;
            ;
            RaycastPerso.extincteur = false;
            Destroy(other.transform.gameObject);            
            empty.SetActive(false);
        }
    }
}
