using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressanykey : MonoBehaviour
{
    public GameObject menu;
    public GameObject start;
    public GameObject sound;

    float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if(timer >= 1f)
        {
            sound.SetActive(true);
        }
        if (Input.anyKey)
        {
            FindObjectOfType<AudioManager>().Play("Clic");
            start.SetActive(false);
            menu.SetActive(true);
        }
    }
}
