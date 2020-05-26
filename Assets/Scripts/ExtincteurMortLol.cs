using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtincteurMortLol : MonoBehaviour
{
    public float timer = 0f;
    public GameObject extincteur;
    public GameObject empty;
    public GameObject auEx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnParticleCollider.boole == true)
        {
            timer = timer + 1 * Time.deltaTime;
        }
        if (timer >= 2f)
        {
            extincteur.SetActive(false);










            auEx.SetActive(true);
            auEx.transform.parent = null;





            RaycastPerso.extincteur = false;

            empty.SetActive(false);
        }
    }
}
