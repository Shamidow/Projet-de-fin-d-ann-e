using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ParticleDMGtest : MonoBehaviour
{

    public ParticleSystem part;
    public Image HealthBar;
    public Image HealthBarG;
    public GameObject dmgScreen;
    private float timer = 0f;
    private bool timerB = false;
    private bool timercoub = false;
    private float timercou = 0f;

    private bool firsttoux = false;

    void Start()
    {
        part = GetComponent<ParticleSystem>();

    }

    private void Update()
    {
        if (timerB == true)
        {
            timer = timer + Time.deltaTime;
        }
        if(timercoub == true)
        {
            timercou = timercou + Time.deltaTime;
        }
        if(timercou >= 5) { 
        
            FindObjectOfType<AudioManager>().Play("VCough2");
            timercou = 0f;
            timercoub = false;
        }
        if (timer >= 0.25f)
        {
            Debug.Log("frérot la vérité je m'en vais");
            dmgScreen.SetActive(false);
            timer = 0f;
            timerB = false;
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            dmgScreen.SetActive(true);
            Debug.Log(other.tag);
            PlayerHP.hp = PlayerHP.hp - 0.20f;
           
            Debug.Log("Nique ta race" + PlayerHP.hp);
            if (firsttoux == false)
            {
                FindObjectOfType<AudioManager>().Play("VCough2");
                firsttoux = true;
            }
            timerB = true;
            timercoub = true;

        }
    }

}
