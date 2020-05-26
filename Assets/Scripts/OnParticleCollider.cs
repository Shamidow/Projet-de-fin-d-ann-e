using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnParticleCollider : MonoBehaviour
{
    public ParticleSystem part;
    public GameObject extincteur;
    public GameObject empty;
    public GameObject auEx;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Obstacle")
        {
            Debug.Log(other.tag);
            Debug.Log("Oeoeoe");

            extincteur.SetActive(false);










            auEx.SetActive(true);
            auEx.transform.parent = null;





            RaycastPerso.extincteur = false;
            Destroy(other.transform.gameObject);
            empty.SetActive(false);
        }
    }
}
