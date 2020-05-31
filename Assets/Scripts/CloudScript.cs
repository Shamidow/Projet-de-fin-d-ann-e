using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public GameObject cloud1;
    public GameObject tuto4;
    public GameObject tuto3;
    public GameObject tuto2;
    public GameObject tuto1;
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
            Destroy(tuto4);
            Destroy(tuto3);
            Destroy(tuto2);
            Destroy(tuto1);
            if(firstTime == false)
            {
                firstclose = true;
                firstTime = true;
                FindObjectOfType<AudioManager>().Play("Door Grillage");
            }
        }
    }
}
