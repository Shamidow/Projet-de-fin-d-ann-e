using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnParticleCollider : MonoBehaviour
{
    public ParticleSystem part;
    public GameObject extincteur;
    public GameObject empty;
    public GameObject auEx;
    public static bool boole = false;
    public float timer = 0f;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        /*if (boole == true)
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
        }*/
    }


    void OnParticleCollision(GameObject other)
    {
        /*if (other.tag == "Obstacle")
        {
            Debug.Log(other.tag);
            Debug.Log("Oeoeoe");

            extincteur.SetActive(false);










            auEx.SetActive(true);
            auEx.transform.parent = null;





            RaycastPerso.extincteur = false;
            Destroy(other.transform.gameObject);
            empty.SetActive(false);
        }*/


        if (other.CompareTag("Obstacle"))
        {
            boole = true;
            Destroy(other.transform.gameObject);
        }

    }
}
