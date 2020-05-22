﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ParticleDMGtest : MonoBehaviour
{
    
    public ParticleSystem part;
    public Image HealthBar;
    public Image HealthBarG;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            PlayerHP.hp = PlayerHP.hp - 0.20f;
            HealthBar.fillAmount = PlayerHP.hp / 100f;
            HealthBarG.fillAmount = PlayerHP.hp / 100f;
            Debug.Log("Nique ta race" + PlayerHP.hp);
        }
    }
}

