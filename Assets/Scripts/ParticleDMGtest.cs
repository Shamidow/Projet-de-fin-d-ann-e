using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDMGtest : MonoBehaviour
{
    
    public ParticleSystem part;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            PlayerHP.hp = PlayerHP.hp - 0.05f;
            Debug.Log("Nique ta race" + PlayerHP.hp);
        }
    }
}

