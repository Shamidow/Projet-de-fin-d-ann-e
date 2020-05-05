using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    AudioSource flashlightsound;
    public GameObject spotlight;
    private bool isactive = true;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isactive == true)
            {
                FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
                isactive = false;
                spotlight.SetActive(false);
                return;

            }
            if (isactive == false)
            {
                FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
                isactive = true;
                spotlight.SetActive(true);
                return;

            }
        }
    }
}
