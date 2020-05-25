using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlashlightController : MonoBehaviour
{
    AudioSource flashlightsound;
    public GameObject spotlight;
    public static bool isactive = false;
    public static float tl = 100f;
    public float timerflash = 0f;
    public bool flCheck = false;
    public bool once = false;
    public bool onceextin = false;
    public Image FlashBar;
    public Image FlashBarG;


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;

    }

    // Update is called once per frame
    void Update()
    {
        tl = Mathf.Clamp(tl, 0, 100);
        FlashBar.fillAmount = tl / 100f;
        // FlashBarG.fillAmount = tl / 100f;
        if (isactive == true)
        {
            
            tl = tl - 6 * Time.deltaTime;

        }
        /*if (flCheck == true)
        {*/
            // Lighttorch();
            if (Input.GetKeyDown(KeyCode.A) && RaycastPerso.torche == true)
            {
                tl = tl + 2.5f;
            FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
        }
            //timerflash = timerflash + Time.deltaTime;
            Debug.Log(tl);
            // if (once == false)
            //{
            //    FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
            //    once = true;
            //}
            //isactive = false;
            // spotlight.SetActive(false);
       // }
        if (timerflash >= 5f)
        {
            flCheck = false;
            timerflash = 0f;
            FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
            isactive = true;
            spotlight.SetActive(true);
            once = false;
        }

        if (Input.GetKeyDown(KeyCode.A) && RaycastPerso.torche == true)
        {
            flCheck = true;
            once = false;
        }

        if (Input.GetKeyDown(KeyCode.F) && RaycastPerso.torche == true)
        {
            if (isactive == true)
            {
                FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
                isactive = false;
                spotlight.SetActive(false);
                return;

            }
            if (isactive == false && tl >= 1)
            {
                FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
                isactive = true;
                spotlight.SetActive(true);
                return;

            }
        }
        if(tl <= 1)
        {
            if (once == false)
            {
                FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
                once = true;
            }
            isactive = false;
            spotlight.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && RaycastPerso.torche == true)
        {
            FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
            isactive = false;
            spotlight.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && RaycastPerso.torche == true)
        {
            FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
            isactive = true;
            spotlight.SetActive(true);
        }
        if(RaycastPerso.extincteur && onceextin == false)
        {
            FindObjectOfType<AudioManager>().Play("Flashlight ON/OFF");
            isactive = false;
            spotlight.SetActive(false);
            onceextin = true;
        }
    }

    public void Lighttorch()
    {
        tl = tl + 0.001f * Time.deltaTime;
       
    }
}
