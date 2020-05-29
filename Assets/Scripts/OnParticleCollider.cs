using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnParticleCollider : MonoBehaviour
{
    public ParticleSystem part;
    public GameObject extincteur;
    public GameObject empty;
    public GameObject auEx;
    public bool boole = false;
    public float timer = 0f;
    private GameObject fire;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (boole == true)
        {
            timer = timer + 1 * Time.deltaTime;
        }
        if (timer >= 1.5f)
        {
            extincteur.SetActive(false);










            auEx.SetActive(true);
            auEx.transform.parent = null;





            RaycastPerso.extincteur = false;

            empty.SetActive(false);
            Destroy(fire);
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Obstacle")
        {
            
            boole = true;
            fire = other;
        }
    }
}
