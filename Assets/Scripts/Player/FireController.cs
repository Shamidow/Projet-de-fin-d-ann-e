using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject co2;
    public AudioSource pshit;
    public static bool ExtinctUse = false;
    void Start()
    {
        ExtinctUse = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            co2.SetActive(true);

            FindObjectOfType<AudioManager>().Play("Extincteur use");
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            co2.SetActive(false);
            ExtinctUse = true;
            FindObjectOfType<AudioManager>().Play("Pshit");
        }
    }

}
