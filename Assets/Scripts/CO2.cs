using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CO2 : MonoBehaviour
{
    public GameObject extincteur;
    public GameObject empty;
    public GameObject auEx;
    public bool boole = false;
    public float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(boole == true)
        {
            timer = timer + 1 * Time.deltaTime;
        }
        if(timer >= 5f)
        {
            extincteur.SetActive(false);










            auEx.SetActive(true);
            auEx.transform.parent = null;





            RaycastPerso.extincteur = false;
            
            empty.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            boole = true;
            Destroy(other.transform.gameObject);
        }
    }
}
