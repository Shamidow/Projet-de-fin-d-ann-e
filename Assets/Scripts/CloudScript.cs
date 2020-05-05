using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public GameObject cloud1;
    private bool firstTime = false;
    public static bool firstclose = false;

    void Start()
    {
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
                FindObjectOfType<AudioManager>().Play("Door Grillage");
            }
        }
    }
}
