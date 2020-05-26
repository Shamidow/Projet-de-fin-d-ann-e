using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ParticleDMGtest : MonoBehaviour
{
    
    public ParticleSystem part;
    public Image HealthBar;
    public Image HealthBarG;
    public GameObject[] Cough;
    private int randomInt;
    private int Timer = 8;
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        randomInt = Random.Range(0, Cough.Length);
        StartCoroutine(RandomCough());
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

    int GetRandom(int count)
    {
        return Random.Range(0, count);
    }

    IEnumerator RandomCough()
    {
        while (Timer != 0)
        {
            randomInt = GetRandom(Cough.Length);
           

           Destroy(Instantiate(Cough[randomInt]), 5f);
            Timer--;
           
            yield return new WaitForSeconds(5f);
        }

        while (Timer <= 0)
        {
            randomInt = GetRandom(Cough.Length);
          

            Destroy(Instantiate(Cough[randomInt]), 5f);

            yield return new WaitForSeconds(5f);
        }
    }
}

