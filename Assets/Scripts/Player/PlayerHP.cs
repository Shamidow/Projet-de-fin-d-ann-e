using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public static float hp = 100, xMin = 0, xMax = 100;
    private bool trigger;
    private bool isDeath = false;
    public GameObject dcamera;
    public GameObject interfacey;
    public GameObject interfaceg;
    public GameObject deathScreen;
    public GameObject pauseMenu;
    void Start()
    {
        dcamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        /* if (trigger == true)
        {
            hp = hp - 3 * Time.deltaTime;
            Debug.Log(hp);

        }*/
        if(isDeath == true)
        { 
        Cursor.visible = true;
        Debug.Log(Cursor.visible);
        }
        if (hp <= 0)
        {
            isDeath = true;
            dcamera.SetActive(true);
            interfaceg.SetActive(false);
            interfacey.SetActive(false);
            dcamera.transform.parent = null;
            deathScreen.SetActive(true);
            Destroy(pauseMenu);

            FindObjectOfType<AudioManager>().Play("Death");
            Cursor.visible = true;
            Destroy(gameObject);
            Cursor.visible = true;
        }
        hp = Mathf.Clamp(hp, 0, 100);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cloud"))
        {
            trigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cloud"))
        {
            trigger = false;
        }
    }
}
