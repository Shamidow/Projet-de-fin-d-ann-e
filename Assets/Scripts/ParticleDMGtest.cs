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
    public Image Imagedmg;
    public GameObject FpsController;
    private float timer = 0f;
    private bool timerB = false;
   
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        Imagedmg = dmgScreen.GetComponent<Image>();
       
        
    }

    private void Update()
    {
        /*if (timerB == true)
        {
            timer = timer + Time.deltaTime;
        }
        if(timer >= 0.25f)
        {
            dmgScreen.SetActive(false);
            timer = 0f;
            timerB = false;
        }*/
        
        
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            
            Debug.Log(other.tag);
            PlayerHP.hp = PlayerHP.hp - 0.20f;           
            var colores = Imagedmg.color;
            colores.a += 0.003f;
            Imagedmg.color = colores;
            //Debug.Log(dmgScreen.GetComponent<Image>().color);
            HealthBar.fillAmount = PlayerHP.hp / 100f;
            HealthBarG.fillAmount = PlayerHP.hp / 100f;
            Debug.Log("Nique ta race" + PlayerHP.hp);
            //timerB = true;

        }
    }
    
}
