using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public GameObject cloud1;
    private bool firstTime = false;
    public static bool firstclose = false;
    AudioSource flashlightsound;

    void Start()
    {
        flashlightsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cloud1.SetActive(true);
            if(firstTime == false)
            {
                firstclose = true;
                firstTime = true;
                flashlightsound.Play(0);
            }
        }
    }
}
